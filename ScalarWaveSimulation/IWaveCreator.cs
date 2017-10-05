using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarWaveSimulation
{
    //Implement this interface to create a customized wave creator to be consumed by the Simulation object
    public interface IWaveCreator
    {
        Wave CreateWave();

        int GetWaveSize();
    }
}
