using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarWaveSimulation
{
    public class TrigWaveCreator: IWaveCreator
    {
        private Func<double, double> _trigFunction;
        private double _amplitude;
        private int _frequency;
        private int _randomnessFactor;
        private int _waveSize;
        private double _waveSpeed;

        public TrigWaveCreator(int waveSize, double waveSpeed, TrigFunction trigFunction,
            double amplitude = 1, int frequency = 1, int randomnessFactor = 0)
        {
            if (waveSize < 10)
                throw new ArgumentOutOfRangeException("waveSize");

            _waveSize = waveSize;
            _waveSpeed = waveSpeed;

            switch (trigFunction)
            {
                case TrigFunction.Sine:
                    _trigFunction = Math.Sin;
                    break;
                case TrigFunction.Cosine:
                    _trigFunction = Math.Cos;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("trigFunction", trigFunction, null);
            }
            
            _amplitude = amplitude;
            _frequency = frequency;
            _randomnessFactor = randomnessFactor;
        }

        public Wave CreateWave()
        {
            var result = new Wave(_waveSize, _waveSpeed);
            var rnd = new Random();
            var rndNum = 1;

            Func<double> getRandomWeight;
            if (_randomnessFactor == 0)
                getRandomWeight = () => 1;
            else
            {

                getRandomWeight = () => (rndNum*_randomnessFactor + rnd.NextDouble())/(_randomnessFactor + 1);
            }

            for (var i = 0; i < result.Nodes; i++)
            {
                var value = _amplitude*getRandomWeight()*_trigFunction(Math.PI*_frequency* ((double)i/result.Nodes));
                result.SetDisplacement(i, value);
            }

            return result;
        }


        public int GetWaveSize()
        {
            return _waveSize;
        }
    }

    public enum TrigFunction
    {
        Sine,
        Cosine
    }
}
