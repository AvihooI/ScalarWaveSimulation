using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ScalarWaveSimulation.UI
{
    public partial class WavePlayer : Form
    {
        Simulation _simulation = null;
        SimulationRenderer _renderer = null;

        int _availableId = 0;

        //Wave creator for simulation
        IWaveCreator _usedWaveCreator;

        //Wave Settings -> Polynomial
        private double _selectedRoot;


        private void RecordDoneCallback(Tuple<double[], double[]>[] record)
        {
            var guid = Guid.NewGuid();

            var fileName = guid.ToString() + ".record";

            using (var file = new StreamWriter(fileName))
            {
                foreach (var element in record)
                {
                    file.WriteLine(JsonConvert.SerializeObject(element.Item1));
                }
            }
        }
        private void CreateSimulation()
        {
            PauseSimulation();
            if (!RecordModeCheckBox.Checked)
            {
                _simulation = new Simulation(_usedWaveCreator);
            }
            else
            {
                long iterations;
                long.TryParse(IterationsTextBox.Text, out iterations);

                if (iterations < 1)
                    iterations = 1;
                if (iterations > 100000)
                    iterations = 100000;

                _simulation = new Simulation(_usedWaveCreator, true, iterations, RecordDoneCallback);
            }
            

            Color mainColor = Color.Blue;
            Color secondaryColor = Color.Red;
            RenderMode renderMode = RenderMode.SingleColor;

            if (_renderer != null)
            {
                mainColor = _renderer.MainColor;
                secondaryColor = _renderer.SecondaryColor;
                renderMode = _renderer.RenderMode;
            }

            _renderer = new SimulationRenderer(_simulation, renderMode, mainColor, secondaryColor);


        }

        private void PauseSimulation()
        {
            if (_simulation != null)
            {
                _simulation.Stop();
            }
        }

        private void StartSimulation()
        {
            if (_simulation != null)
            {
                _simulation.Start();
            }
        }
        
        public WavePlayer()
        {
            _selectedRoot = 0;
            _usedWaveCreator = new ZeroWaveCreator(100);
            InitializeComponent();
        }

        private void RootTrackBar_Scroll(object sender, EventArgs e)
        {
            _selectedRoot = (double)RootTrackBar.Value / 10;
            RootViewLabel.Text = _selectedRoot.ToString();
        }

        private void AddRootButton_Click(object sender, EventArgs e)
        {
            RootsListBox.Items.Add(_selectedRoot);
        }

        private void DeleteRootButton_Click(object sender, EventArgs e)
        {
            if (RootsListBox.SelectedIndex != -1)
            {
                RootsListBox.Items.RemoveAt(RootsListBox.SelectedIndex);
            }
        }

        private int GetWaveSize()
        {
            int waveSize = 100;

            int.TryParse(WaveSizeTextBox.Text, out waveSize);

            if (waveSize < 100)
                waveSize = 100;

            return waveSize;
        }

        private double GetWaveSpeed()
        {
            double waveSpeed = 1;

            double.TryParse(WaveSpeedTextBox.Text, out waveSpeed);

            if (waveSpeed == 0)
                waveSpeed = 1;

            return waveSpeed;
        }

        private void CreatePolynomialWaveButton_Click(object sender, EventArgs e)
        {
            double amplitude = 0;

            if (!Double.TryParse(PolynomialAmplitudeTextBox.Text, out amplitude))
            {
                MessageBox.Show("Illegal amplitude");
            }
            else
            {
                var internalRoots = RootsListBox.Items.Cast<double>().ToArray();
                var newWaveCreator = new PolynomialWaveCreator(GetWaveSize(), GetWaveSpeed(), amplitude, internalRoots);

                AddWaveCreatorToList(newWaveCreator, "Polynomial Wave");
            }
        }

        private void AddWaveCreatorToList(IWaveCreator newWaveCreator, string waveTypeName)
        {
            var newWaveListBoxItem = new WaveListBoxItem(newWaveCreator, waveTypeName + " " + _availableId.ToString());
            _availableId++;

            WavesListBox.Items.Add(newWaveListBoxItem);
        }

        private void UseWaveButton_Click(object sender, EventArgs e)
        {
            if (WavesListBox.SelectedIndex != -1)
            {
                var waveListBoxItem = (WaveListBoxItem)WavesListBox.SelectedItem;
                UsedWaveLabel.Text = "Using " + waveListBoxItem.ToString();

                _usedWaveCreator = (waveListBoxItem.WaveCreator);
            }
        }

        private void DeleteWaveButton_Click(object sender, EventArgs e)
        {
            if (WavesListBox.SelectedIndex != -1)
            {
                WavesListBox.Items.RemoveAt(WavesListBox.SelectedIndex);
            }
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            if (_renderer != null)
            {
                waveView.Refresh();
            }
        }

        private void waveView_Paint(object sender, PaintEventArgs e)
        {
            if (_renderer != null)
            {
                _renderer.Draw(e.Graphics);
            }
            else
            {
                e.Graphics.Clear(Color.White);
            }
        }

        private void CreateSimulationButton_Click(object sender, EventArgs e)
        {
            CreateSimulation();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartSimulation();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            PauseSimulation();
        }

        private void CreateTrigWaveButton_Click(object sender, EventArgs e)
        {
            _usedWaveCreator = new TrigWaveCreator(GetWaveSize(), GetWaveSpeed(), GetTrigType(), GetTrigAmplitude(), GetFrequency(), GetRandomnessFactor());
            AddWaveCreatorToList(_usedWaveCreator, "Trigonometric Wave");
        }

        private int GetRandomnessFactor()
        {
            int result;
            try
            {
                result = int.Parse(RandomnessFactorTextBox.Text);
                if(result <= 0)
                {
                    result = 0;
                }
            }
            catch (Exception e)
            {
                result = 0;
            }

            return result;
        }

        private int GetFrequency()
        {
            int result;
            try
            {
                result = int.Parse(FrequencyTextBox.Text);
                if (result < 1)
                {
                    result = 1;
                }
            }
            catch(Exception e)
            {
                result = 1;
            }
            return result;
        }

        private double GetTrigAmplitude()
        {
            double result;
            try
            {
                result = double.Parse(TrigAmplitudeTextBox.Text);
            }
            catch (Exception e)
            {
                result = 5;
            }
            return result;
        }

        private Color GetProperTextColor(Color backgroundColor)
        {
            Color result = Color.Black;

            if ((int)Math.Sqrt(backgroundColor.R + backgroundColor.G + backgroundColor.B) < 20)
            {
                result = Color.White;
            }

            return result;
        }
        private TrigFunction GetTrigType()
        {
            TrigFunction type;

            switch (TypeComboBox.SelectedIndex)
            {
                case 0:
                    type = TrigFunction.Sine;
                    break;

                default:
                    type = TrigFunction.Cosine;
                    break;
            }

            return type;
        }

        private void AddWaveButton_Click(object sender, EventArgs e)
        {
            if (WavesListBox.SelectedIndex != -1)
            {
                var waveListBoxItem = (WaveListBoxItem)WavesListBox.SelectedItem;

                if(CombinerListBox.Items.Count < 2)
                {
                    CombinerListBox.Items.Add(waveListBoxItem);
                }
            }
        }

        private void RemoveWaveButton_Click(object sender, EventArgs e)
        {
            if(CombinerListBox.SelectedIndex != -1)
            {
                CombinerListBox.Items.RemoveAt(CombinerListBox.SelectedIndex);
            }

        }

        private void SwapWavesButton_Click(object sender, EventArgs e)
        {
            if(CombinerListBox.Items.Count == 2)
            {
                var temp = CombinerListBox.Items[0];
                CombinerListBox.Items[0] = CombinerListBox.Items[1];
                CombinerListBox.Items[1] = temp;
            }
        }

        private CombinerMode GetCombinerMode()
        {
            CombinerMode mode;

            switch(CombinerModeComboBox.SelectedIndex)
            {
                case 0:
                    mode = CombinerMode.Add;
                    break;

                default:
                    mode = CombinerMode.Chain;
                    break;
            }

            return mode;
        }

        private void CreateWaveCombinationButton_Click(object sender, EventArgs e)
        {
            if(CombinerListBox.Items.Count != 2)
            {
                MessageBox.Show("Two waves are required in order to combine.");
                return;
            }

            var firstWaveCreator = ((WaveListBoxItem)CombinerListBox.Items[0]).WaveCreator;
            var secondWaveCreator = ((WaveListBoxItem)CombinerListBox.Items[1]).WaveCreator;

            try
            {
                var combinedWave = new CombinerWaveCreator(GetWaveSpeed(), GetCombinerMode(), firstWaveCreator, secondWaveCreator);
                AddWaveCreatorToList(combinedWave, "Combined Wave");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void WavePlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            PauseSimulation();
        }

        private void CreateZeroWaveButton_Click(object sender, EventArgs e)
        {
            var zeroWave = new ZeroWaveCreator(GetWaveSize());
            AddWaveCreatorToList(zeroWave, "Zero Wave");
        }

        private void OnItemSelectedChanged(object sender, EventArgs e)
        {
            if(WavesListBox.SelectedIndex != -1)
            {
                string size = ((WaveListBoxItem)WavesListBox.SelectedItem).WaveCreator.GetWaveSize().ToString();
                WaveSizeIndicatorTextBox.Text = size;
            }
        }


        private void UpdateColorPickerButtons()
        {
            if (_renderer != null)
            {
                SelectMainColorButton.BackColor = _renderer.MainColor;
                SelectMainColorButton.ForeColor = GetProperTextColor(SelectMainColorButton.BackColor);
                SelectSecondaryColorButton.BackColor = _renderer.SecondaryColor;
                SelectSecondaryColorButton.ForeColor = GetProperTextColor(SelectSecondaryColorButton.BackColor);
            }
        }
        private void RendererTab_Enter(object sender, EventArgs e)
        {
            UpdateColorPickerButtons();
        }

        private void SelectMainColorButton_Click(object sender, EventArgs e)
        {
            if (_renderer != null)
            {
                ColorDialog.ShowDialog();
                _renderer.MainColor = ColorDialog.Color;
            }
            UpdateColorPickerButtons();
        }

        private void SelectSecondaryColorButton_Click(object sender, EventArgs e)
        {
            if (_renderer != null)
            {
                ColorDialog.ShowDialog();
                _renderer.SecondaryColor = ColorDialog.Color;
            }
            UpdateColorPickerButtons();
        }

        private void SingleColorRenderModeButton_Click(object sender, EventArgs e)
        {
            if (_renderer != null)
            {
                _renderer.RenderMode = RenderMode.SingleColor;
            }
        }

        private void DisplacementColorModeButton_Click(object sender, EventArgs e)
        {
            if (_renderer != null)
            {
                _renderer.RenderMode = RenderMode.DisplacementColor;
            }
        }

        private void VelocityColorModeButton_Click(object sender, EventArgs e)
        {
            if (_renderer != null)
            {
                _renderer.RenderMode = RenderMode.VelocityColor;
            }
        }

        private void AccelerationColorModeButton_Click(object sender, EventArgs e)
        {
            if (_renderer != null)
            {
                _renderer.RenderMode = RenderMode.AccelerationColor;
            }
        }
    }
}
