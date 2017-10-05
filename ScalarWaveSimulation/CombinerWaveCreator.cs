using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarWaveSimulation
{
    public class CombinerWaveCreator: IWaveCreator
    {
        private double _waveSpeed;
        private CombinerMode _combinerMode;
        private IWaveCreator _creator1;
        private IWaveCreator _creator2;
        public CombinerWaveCreator(double waveSpeed, CombinerMode combinerMode, IWaveCreator creator1, IWaveCreator creator2)
        {
            _waveSpeed = waveSpeed;
            _combinerMode = combinerMode;
            _creator1 = creator1;
            _creator2 = creator2;

            if (_combinerMode == CombinerMode.Add && _creator1.GetWaveSize() != _creator2.GetWaveSize())
                throw new InvalidOperationException("Trying to add two waves of inequal sizes");

        }
        public Wave CreateWave()
        {
            var wave1Snapshot = _creator1.CreateWave().CreateDisplacementsSnapshot();
            var wave2Snapshot = _creator2.CreateWave().CreateDisplacementsSnapshot();
            Wave result = null;

            switch(_combinerMode)
            {
                case CombinerMode.Add:
                    if (wave1Snapshot.Length != wave2Snapshot.Length)
                        throw new InvalidOperationException("Trying to add two waves of inequal sizes (at wave creation)");

                    result = new Wave(wave1Snapshot.Length, _waveSpeed);
                    for (var i = 0; i < wave1Snapshot.Length; i++)
                    {
                        result.SetDisplacement(i, wave1Snapshot[i] + wave2Snapshot[i]);
                    }
                    break;
                case CombinerMode.Chain:
                    var length = wave1Snapshot.Length + wave2Snapshot.Length;
                    result = new Wave(length, _waveSpeed);

                    for (var i = 0; i < wave1Snapshot.Length; i++)
                    {
                        result.SetDisplacement(i, wave1Snapshot[i]);
                    }

                    for (var i = 0; i < wave2Snapshot.Length; i++)
                    {
                        result.SetDisplacement(i + wave1Snapshot.Length,wave2Snapshot[i]);
                    }

                    break;
                default:
                    throw new ArgumentOutOfRangeException("CombinerMode");
            }

            return result;
        }


        public int GetWaveSize()
        {
            var result = 0;

            switch(_combinerMode)
            {
                case CombinerMode.Add:
                    result = _creator1.GetWaveSize();
                    break;
                case CombinerMode.Chain:
                    result = _creator1.GetWaveSize() + _creator2.GetWaveSize();
                    break;
            }

            return result;
        }
    }
    
    public enum CombinerMode
    {
        Add,
        Chain
    }
}
