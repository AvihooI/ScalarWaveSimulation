using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarWaveSimulation.UI
{
    public class WaveListBoxItem
    {
        private IWaveCreator _waveCreator;
        private string _name;

        public IWaveCreator WaveCreator 
        {
            get
            {
                return _waveCreator;
            }
        }
        public WaveListBoxItem(IWaveCreator waveCreator, string name)
        {
            _waveCreator = waveCreator;
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }


    }
}
