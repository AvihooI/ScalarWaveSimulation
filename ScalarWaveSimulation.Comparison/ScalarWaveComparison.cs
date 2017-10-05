using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScalarWaveSimulation.Comparison
{
    public partial class ScalarWaveComparison : Form
    {
        private readonly double[,] _uNumerical;
        private int _selectedTime = 0;
        private ComparisonRenderer _renderer;
        private double G(double x)
        {
            return 40*Math.Sin(x*Math.PI/200);
        }

        private double U(double x, double t)
        {
            return (G(x-800*t) + G(x+800*t))/2;
        }
        public ScalarWaveComparison()
        {
            var wave = new Wave(400, 800);
            _renderer = new ComparisonRenderer();

            //Use G(x) to populate the wave's displacements

            for (var i = 0; i < 400; i++)
            {
                wave.SetDisplacement(i, G(i));
            }

            _uNumerical = new double[10000,400];

            for (var t = 0; t < 10000; t++)
            {
                for (var x = 0; x < 400; x++)
                {
                    _uNumerical[t, x] = wave.GetDisplacement(x);
                }
                wave.Iterate(1);
            }

            InitializeComponent();
        }

        private void ComparisonTimer_Tick(object sender, EventArgs e)
        {
            ComparisonView.Refresh();

            if (AutoIncrementCheckbox.Checked)
            {
                _selectedTime++;
                TimeTextBox.Text = _selectedTime.ToString();
            }

            if (_selectedTime > 10000)
                _selectedTime = 0;
        }

        private void ComparisonView_Paint(object sender, PaintEventArgs e)
        {
            var numericalSnapshot = new double[400];
            var analyticalSnapshot = new double[400];

            for (var i = 0; i < 400; i++)
            {
                numericalSnapshot[i] = _uNumerical[_selectedTime, i];
                analyticalSnapshot[i] = U(i, (double)_selectedTime/1000);
            }

            _renderer.Draw(e.Graphics,numericalSnapshot, analyticalSnapshot);
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            AutoIncrementCheckbox.Checked = false;

            var time = 0;
            int.TryParse(TimeTextBox.Text, out time);


            if (time >= 10000)
                time = 9999;
            if (time < 0)
                time = 0;

            _selectedTime = time;

        }

    }
}
