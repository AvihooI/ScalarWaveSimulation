using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScalarWaveSimulation
{
    public class Wave
    {
        private double _waveSpeed;
        private double[] _displacements;
        private double[] _velocities;
        private double[] _accelerations;

        public int Nodes;

        public Wave(int nodes, double waveSpeed = 1)
        {
            Nodes = nodes;
            _waveSpeed = waveSpeed;

            _displacements = new double[nodes];
            _velocities = new double[nodes];
            _accelerations = new double[nodes];
        }

        public Wave Copy()
        {
            var copy = new Wave(Nodes, _waveSpeed);

            copy._displacements = _displacements.ToArray();
            copy._velocities = _displacements.ToArray();

            return copy;
        }

        public double GetDisplacement(int index)
        {
            if (index < 0 || index >= Nodes)
                return 0;

            return _displacements[index];
        }

        public void SetDisplacement(int index, double value)
        {
            if (index < 0 || index >= Nodes)
                return;

            _displacements[index] = value;
        }

        public void SetVelocity(int index, double value)
        {
            if (index < 0 || index >= Nodes)
                return;

            _velocities[index] = value;
        }

        public void SetAmplitude(double amplitude)
        {
            var currentAmplitude = _displacements.Max(x => Math.Abs(x));
            var factor = amplitude/currentAmplitude;

            for (var i = 0; i < _displacements.Length; i++)
            {
                _displacements[i] *= factor;
            }
        }

        public double GetAcceleration(int index)
        {

            var result = -GetDisplacement(index + 2) + 16*GetDisplacement(index + 1) - 30*GetDisplacement(index) +
                            16*GetDisplacement(index - 1) - GetDisplacement(index - 2);

            result *= Math.Pow(_waveSpeed, 2)/12;

            return result;
        }

        public void Iterate(int deltaT)
        {
            for (var i = 0; i < Nodes; i++)
            {
                _accelerations[i] = GetAcceleration(i);
            }

            for (var i = 0; i < Nodes; i++)
            {
                _velocities[i] += _accelerations[i]*((double) deltaT/1000);
            }

            for (var i = 0; i < Nodes; i++)
            {
                _displacements[i] += _velocities[i]*((double)deltaT/1000);
            }
        }

        public double[] CreateDisplacementsSnapshot()
        {
            var result = new double[Nodes];

            Array.Copy(_displacements, result, Nodes);

            return result;
        }

        public double[] CreateVelocitiesSnapshot()
        {
            var result = new double[Nodes];

            Array.Copy(_velocities, result, Nodes);

            return result;
        }

        public double[] CreateAccelerationsSnapshot()
        {
            var result = new double[Nodes];

            Array.Copy(_accelerations, result, Nodes);

            return result;
        }
    }
}
