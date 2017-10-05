using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarWaveSimulation
{
    public class ZeroWaveCreator: IWaveCreator
    {
        private int _waveSize;
        public ZeroWaveCreator(int waveSize)
        {
            _waveSize = waveSize;
        }

        public Wave CreateWave()
        {
            return new Wave(_waveSize);
        }


        public int GetWaveSize()
        {
            return _waveSize;
        }
    }
}
