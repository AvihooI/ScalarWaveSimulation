using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ScalarWaveSimulation
{
    public class PolynomialWaveCreator: IWaveCreator
    {
        private int _waveSize;
        private double _waveSpeed;
        private double[] _internalRoots;
        private double _amplitude;

        public PolynomialWaveCreator(int waveSize, double waveSpeed, double amplitude, IEnumerable<double> internalRoots)
        {
            _waveSize = waveSize;
            _waveSpeed = waveSpeed;
            _amplitude = amplitude;
            _internalRoots = internalRoots.ToArray();

            if (_internalRoots.Any(x => x > 1 || x < 0))
            {
                throw new ArgumentOutOfRangeException("internalRoots");
            }
        }
        public Wave CreateWave()
        {
            var result = new Wave(_waveSize, _waveSpeed);

            for (var i = 0; i < result.Nodes; i++)
            {
                double product = i*(i-result.Nodes-1);

                foreach (var weight in _internalRoots)
                {
                    product *= (i - weight*(result.Nodes));
                }

                var value = product;
                result.SetDisplacement(i, value);
            }

            result.SetAmplitude(_amplitude);

            return result;
        }


        public int GetWaveSize()
        {
            return _waveSize;
        }
    }
}
