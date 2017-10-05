using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ScalarWaveSimulation
{
    public class Simulation
    {
        private Wave _wave;
        private bool _run;
        private int _actualDeltaT;
        private readonly long _recordIterations;
        private long _currentIteration;
        private readonly bool _recordMode;
        private readonly List<Tuple<double[], double[]>> _record = null;
        private readonly Action<Tuple<double[], double[]>[]> _recordDoneCallback = null;
        private Wave _initialWave;

        public Simulation(IWaveCreator waveCreator, bool recordMode = false, long recordIterations = 1000, Action<Tuple<double[], double[]>[]> recordDoneCallback = null)
            : this(waveCreator.CreateWave(), recordMode, recordIterations, recordDoneCallback)
        {
            
        }
        public Simulation(Wave wave, bool recordMode = false, long recordIterations = 1000, Action<Tuple<double[],double[]>[]> recordDoneCallback = null)
        {
            _wave = wave;
            _recordMode = recordMode;
            _recordIterations = recordIterations;
            _currentIteration = 0;
            if (_recordMode)
            {
                _record = new List<Tuple<double[], double[]>>();
                _recordDoneCallback = recordDoneCallback;
                _initialWave = _wave.Copy();
            }
        }

        private void ThreadLoop()
        {
            var stopWatch = new Stopwatch();
            _actualDeltaT = 1;
            
            while (_run)
            {
                if (!_recordMode)
                {
                    stopWatch.Restart();
                    _wave.Iterate(_actualDeltaT);
                    stopWatch.Stop();
                    _actualDeltaT = (int) stopWatch.ElapsedMilliseconds;
                    if (_actualDeltaT > 10)
                        _actualDeltaT = 10;
                    if (_actualDeltaT < 1)
                        _actualDeltaT = 1;
                }
                else
                {
                    if (_currentIteration == _recordIterations)
                    {
                        _run = false;
                        break;
                    }
                    _record.Add(new Tuple<double[], double[]>(_wave.CreateDisplacementsSnapshot(), _wave.CreateVelocitiesSnapshot()));
                    _wave.Iterate(1);
                    _currentIteration++;
                }
            }

            if (_recordMode)
            {
                _wave = _initialWave.Copy();
                _currentIteration = 0;
                _recordDoneCallback(_record.ToArray());
            }
        }

        public void Start()
        {
            if (_run)
                return;

            _run = true;
            var thread = new Thread(ThreadLoop);
            thread.Start();
        }

        public void Stop()
        {
            if (!_run)
                return;

            _run = false;
        }

        public double[] CreateDisplacementsSnapshot()
        {
            return _wave.CreateDisplacementsSnapshot();
        }

        public double[] CreateVelocitiesSnapshot()
        {
            return _wave.CreateVelocitiesSnapshot();
        }

        public double[] CreateAccelerationsSnapshot()
        {
            return _wave.CreateAccelerationsSnapshot();
        }
    }
}
