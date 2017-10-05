namespace ScalarWaveSimulation.UI
{
    partial class WavePlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.waveView = new System.Windows.Forms.PictureBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.PauseButton = new System.Windows.Forms.Button();
            this.OptionsTabControl = new System.Windows.Forms.TabControl();
            this.SimulationTab = new System.Windows.Forms.TabPage();
            this.UsedWaveLabel = new System.Windows.Forms.Label();
            this.CreateSimulationButton = new System.Windows.Forms.Button();
            this.RendererTab = new System.Windows.Forms.TabPage();
            this.AccelerationColorModeButton = new System.Windows.Forms.Button();
            this.VelocityColorModeButton = new System.Windows.Forms.Button();
            this.DisplacementColorModeButton = new System.Windows.Forms.Button();
            this.SingleColorRenderModeButton = new System.Windows.Forms.Button();
            this.SelectSecondaryColorButton = new System.Windows.Forms.Button();
            this.SelectMainColorButton = new System.Windows.Forms.Button();
            this.WaveSettingsTab = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WaveSizeIndicatorTextBox = new System.Windows.Forms.TextBox();
            this.DeleteWaveButton = new System.Windows.Forms.Button();
            this.BasicWaveSettings = new System.Windows.Forms.GroupBox();
            this.CreateZeroWaveButton = new System.Windows.Forms.Button();
            this.WaveSizeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.WaveSpeedTextBox = new System.Windows.Forms.TextBox();
            this.WaveCreatorTabControl = new System.Windows.Forms.TabControl();
            this.PolynomialTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RootViewLabel = new System.Windows.Forms.Label();
            this.RootTrackBar = new System.Windows.Forms.TrackBar();
            this.DeleteRootButton = new System.Windows.Forms.Button();
            this.AddRootButton = new System.Windows.Forms.Button();
            this.RootsListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreatePolynomialWaveButton = new System.Windows.Forms.Button();
            this.PolynomialAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.TrigTab = new System.Windows.Forms.TabPage();
            this.CreateTrigWaveButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FrequencyTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.RandomnessFactorTextBox = new System.Windows.Forms.TextBox();
            this.TrigAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CombinerTab = new System.Windows.Forms.TabPage();
            this.CreateWaveCombinationButton = new System.Windows.Forms.Button();
            this.SwapWavesButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CombinerModeComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveWaveButton = new System.Windows.Forms.Button();
            this.AddWaveButton = new System.Windows.Forms.Button();
            this.CombinerListBox = new System.Windows.Forms.ListBox();
            this.UseWaveButton = new System.Windows.Forms.Button();
            this.WavesListBox = new System.Windows.Forms.ListBox();
            this.RenderTimer = new System.Windows.Forms.Timer(this.components);
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.RecordModeCheckBox = new System.Windows.Forms.CheckBox();
            this.IterationsTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.waveView)).BeginInit();
            this.OptionsTabControl.SuspendLayout();
            this.SimulationTab.SuspendLayout();
            this.RendererTab.SuspendLayout();
            this.WaveSettingsTab.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.BasicWaveSettings.SuspendLayout();
            this.WaveCreatorTabControl.SuspendLayout();
            this.PolynomialTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RootTrackBar)).BeginInit();
            this.TrigTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CombinerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // waveView
            // 
            this.waveView.BackColor = System.Drawing.Color.Black;
            this.waveView.Location = new System.Drawing.Point(12, 12);
            this.waveView.Name = "waveView";
            this.waveView.Size = new System.Drawing.Size(500, 500);
            this.waveView.TabIndex = 0;
            this.waveView.TabStop = false;
            this.waveView.Paint += new System.Windows.Forms.PaintEventHandler(this.waveView_Paint);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 518);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(125, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Location = new System.Drawing.Point(387, 518);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(125, 23);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // OptionsTabControl
            // 
            this.OptionsTabControl.Controls.Add(this.SimulationTab);
            this.OptionsTabControl.Controls.Add(this.RendererTab);
            this.OptionsTabControl.Controls.Add(this.WaveSettingsTab);
            this.OptionsTabControl.Location = new System.Drawing.Point(553, 12);
            this.OptionsTabControl.Name = "OptionsTabControl";
            this.OptionsTabControl.SelectedIndex = 0;
            this.OptionsTabControl.Size = new System.Drawing.Size(500, 500);
            this.OptionsTabControl.TabIndex = 2;
            // 
            // SimulationTab
            // 
            this.SimulationTab.Controls.Add(this.label9);
            this.SimulationTab.Controls.Add(this.IterationsTextBox);
            this.SimulationTab.Controls.Add(this.RecordModeCheckBox);
            this.SimulationTab.Controls.Add(this.UsedWaveLabel);
            this.SimulationTab.Controls.Add(this.CreateSimulationButton);
            this.SimulationTab.Location = new System.Drawing.Point(4, 22);
            this.SimulationTab.Name = "SimulationTab";
            this.SimulationTab.Size = new System.Drawing.Size(492, 474);
            this.SimulationTab.TabIndex = 0;
            this.SimulationTab.Text = "Simulation";
            this.SimulationTab.UseVisualStyleBackColor = true;
            // 
            // UsedWaveLabel
            // 
            this.UsedWaveLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsedWaveLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsedWaveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UsedWaveLabel.Location = new System.Drawing.Point(3, 220);
            this.UsedWaveLabel.Name = "UsedWaveLabel";
            this.UsedWaveLabel.Size = new System.Drawing.Size(485, 110);
            this.UsedWaveLabel.TabIndex = 1;
            this.UsedWaveLabel.Text = "Using Default Wave";
            this.UsedWaveLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateSimulationButton
            // 
            this.CreateSimulationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateSimulationButton.Location = new System.Drawing.Point(3, 333);
            this.CreateSimulationButton.Name = "CreateSimulationButton";
            this.CreateSimulationButton.Size = new System.Drawing.Size(485, 138);
            this.CreateSimulationButton.TabIndex = 0;
            this.CreateSimulationButton.Text = "Create Simulation";
            this.CreateSimulationButton.UseVisualStyleBackColor = true;
            this.CreateSimulationButton.Click += new System.EventHandler(this.CreateSimulationButton_Click);
            // 
            // RendererTab
            // 
            this.RendererTab.Controls.Add(this.AccelerationColorModeButton);
            this.RendererTab.Controls.Add(this.VelocityColorModeButton);
            this.RendererTab.Controls.Add(this.DisplacementColorModeButton);
            this.RendererTab.Controls.Add(this.SingleColorRenderModeButton);
            this.RendererTab.Controls.Add(this.SelectSecondaryColorButton);
            this.RendererTab.Controls.Add(this.SelectMainColorButton);
            this.RendererTab.Location = new System.Drawing.Point(4, 22);
            this.RendererTab.Name = "RendererTab";
            this.RendererTab.Size = new System.Drawing.Size(492, 474);
            this.RendererTab.TabIndex = 1;
            this.RendererTab.Text = "Renderer";
            this.RendererTab.UseVisualStyleBackColor = true;
            this.RendererTab.Enter += new System.EventHandler(this.RendererTab_Enter);
            // 
            // AccelerationColorModeButton
            // 
            this.AccelerationColorModeButton.Location = new System.Drawing.Point(3, 356);
            this.AccelerationColorModeButton.Name = "AccelerationColorModeButton";
            this.AccelerationColorModeButton.Size = new System.Drawing.Size(484, 41);
            this.AccelerationColorModeButton.TabIndex = 2;
            this.AccelerationColorModeButton.Text = "Acceleration Color Mode";
            this.AccelerationColorModeButton.UseVisualStyleBackColor = true;
            this.AccelerationColorModeButton.Click += new System.EventHandler(this.AccelerationColorModeButton_Click);
            // 
            // VelocityColorModeButton
            // 
            this.VelocityColorModeButton.Location = new System.Drawing.Point(3, 309);
            this.VelocityColorModeButton.Name = "VelocityColorModeButton";
            this.VelocityColorModeButton.Size = new System.Drawing.Size(484, 41);
            this.VelocityColorModeButton.TabIndex = 2;
            this.VelocityColorModeButton.Text = "Velocity Color Mode";
            this.VelocityColorModeButton.UseVisualStyleBackColor = true;
            this.VelocityColorModeButton.Click += new System.EventHandler(this.VelocityColorModeButton_Click);
            // 
            // DisplacementColorModeButton
            // 
            this.DisplacementColorModeButton.Location = new System.Drawing.Point(3, 262);
            this.DisplacementColorModeButton.Name = "DisplacementColorModeButton";
            this.DisplacementColorModeButton.Size = new System.Drawing.Size(484, 41);
            this.DisplacementColorModeButton.TabIndex = 2;
            this.DisplacementColorModeButton.Text = "Displacement Color Mode";
            this.DisplacementColorModeButton.UseVisualStyleBackColor = true;
            this.DisplacementColorModeButton.Click += new System.EventHandler(this.DisplacementColorModeButton_Click);
            // 
            // SingleColorRenderModeButton
            // 
            this.SingleColorRenderModeButton.Location = new System.Drawing.Point(4, 215);
            this.SingleColorRenderModeButton.Name = "SingleColorRenderModeButton";
            this.SingleColorRenderModeButton.Size = new System.Drawing.Size(484, 41);
            this.SingleColorRenderModeButton.TabIndex = 2;
            this.SingleColorRenderModeButton.Text = "Single Color Mode";
            this.SingleColorRenderModeButton.UseVisualStyleBackColor = true;
            this.SingleColorRenderModeButton.Click += new System.EventHandler(this.SingleColorRenderModeButton_Click);
            // 
            // SelectSecondaryColorButton
            // 
            this.SelectSecondaryColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectSecondaryColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SelectSecondaryColorButton.Location = new System.Drawing.Point(3, 109);
            this.SelectSecondaryColorButton.Name = "SelectSecondaryColorButton";
            this.SelectSecondaryColorButton.Size = new System.Drawing.Size(485, 100);
            this.SelectSecondaryColorButton.TabIndex = 1;
            this.SelectSecondaryColorButton.Text = "Select Secondary Color";
            this.SelectSecondaryColorButton.UseVisualStyleBackColor = true;
            this.SelectSecondaryColorButton.Click += new System.EventHandler(this.SelectSecondaryColorButton_Click);
            // 
            // SelectMainColorButton
            // 
            this.SelectMainColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectMainColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SelectMainColorButton.Location = new System.Drawing.Point(4, 4);
            this.SelectMainColorButton.Name = "SelectMainColorButton";
            this.SelectMainColorButton.Size = new System.Drawing.Size(485, 100);
            this.SelectMainColorButton.TabIndex = 0;
            this.SelectMainColorButton.Text = "Select Main Color";
            this.SelectMainColorButton.UseVisualStyleBackColor = true;
            this.SelectMainColorButton.Click += new System.EventHandler(this.SelectMainColorButton_Click);
            // 
            // WaveSettingsTab
            // 
            this.WaveSettingsTab.Controls.Add(this.groupBox3);
            this.WaveSettingsTab.Controls.Add(this.DeleteWaveButton);
            this.WaveSettingsTab.Controls.Add(this.BasicWaveSettings);
            this.WaveSettingsTab.Controls.Add(this.WaveCreatorTabControl);
            this.WaveSettingsTab.Controls.Add(this.UseWaveButton);
            this.WaveSettingsTab.Controls.Add(this.WavesListBox);
            this.WaveSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.WaveSettingsTab.Name = "WaveSettingsTab";
            this.WaveSettingsTab.Size = new System.Drawing.Size(492, 474);
            this.WaveSettingsTab.TabIndex = 2;
            this.WaveSettingsTab.Text = "Wave Settings";
            this.WaveSettingsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WaveSizeIndicatorTextBox);
            this.groupBox3.Location = new System.Drawing.Point(370, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 39);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wave Size";
            // 
            // WaveSizeIndicatorTextBox
            // 
            this.WaveSizeIndicatorTextBox.Enabled = false;
            this.WaveSizeIndicatorTextBox.Location = new System.Drawing.Point(6, 13);
            this.WaveSizeIndicatorTextBox.Name = "WaveSizeIndicatorTextBox";
            this.WaveSizeIndicatorTextBox.Size = new System.Drawing.Size(107, 20);
            this.WaveSizeIndicatorTextBox.TabIndex = 0;
            // 
            // DeleteWaveButton
            // 
            this.DeleteWaveButton.Location = new System.Drawing.Point(370, 341);
            this.DeleteWaveButton.Name = "DeleteWaveButton";
            this.DeleteWaveButton.Size = new System.Drawing.Size(119, 23);
            this.DeleteWaveButton.TabIndex = 6;
            this.DeleteWaveButton.Text = "Delete Wave";
            this.DeleteWaveButton.UseVisualStyleBackColor = true;
            this.DeleteWaveButton.Click += new System.EventHandler(this.DeleteWaveButton_Click);
            // 
            // BasicWaveSettings
            // 
            this.BasicWaveSettings.Controls.Add(this.CreateZeroWaveButton);
            this.BasicWaveSettings.Controls.Add(this.WaveSizeTextBox);
            this.BasicWaveSettings.Controls.Add(this.label2);
            this.BasicWaveSettings.Controls.Add(this.label1);
            this.BasicWaveSettings.Controls.Add(this.WaveSpeedTextBox);
            this.BasicWaveSettings.Location = new System.Drawing.Point(8, 341);
            this.BasicWaveSettings.Name = "BasicWaveSettings";
            this.BasicWaveSettings.Size = new System.Drawing.Size(355, 119);
            this.BasicWaveSettings.TabIndex = 5;
            this.BasicWaveSettings.TabStop = false;
            this.BasicWaveSettings.Text = "Basic Wave Settings";
            // 
            // CreateZeroWaveButton
            // 
            this.CreateZeroWaveButton.Location = new System.Drawing.Point(208, 15);
            this.CreateZeroWaveButton.Name = "CreateZeroWaveButton";
            this.CreateZeroWaveButton.Size = new System.Drawing.Size(131, 61);
            this.CreateZeroWaveButton.TabIndex = 5;
            this.CreateZeroWaveButton.Text = "Create Zero Wave";
            this.CreateZeroWaveButton.UseVisualStyleBackColor = true;
            this.CreateZeroWaveButton.Click += new System.EventHandler(this.CreateZeroWaveButton_Click);
            // 
            // WaveSizeTextBox
            // 
            this.WaveSizeTextBox.Location = new System.Drawing.Point(97, 19);
            this.WaveSizeTextBox.Name = "WaveSizeTextBox";
            this.WaveSizeTextBox.Size = new System.Drawing.Size(79, 20);
            this.WaveSizeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wave Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wave Size";
            // 
            // WaveSpeedTextBox
            // 
            this.WaveSpeedTextBox.Location = new System.Drawing.Point(97, 56);
            this.WaveSpeedTextBox.Name = "WaveSpeedTextBox";
            this.WaveSpeedTextBox.Size = new System.Drawing.Size(79, 20);
            this.WaveSpeedTextBox.TabIndex = 3;
            // 
            // WaveCreatorTabControl
            // 
            this.WaveCreatorTabControl.Controls.Add(this.PolynomialTab);
            this.WaveCreatorTabControl.Controls.Add(this.TrigTab);
            this.WaveCreatorTabControl.Controls.Add(this.CombinerTab);
            this.WaveCreatorTabControl.Location = new System.Drawing.Point(4, 4);
            this.WaveCreatorTabControl.Name = "WaveCreatorTabControl";
            this.WaveCreatorTabControl.SelectedIndex = 0;
            this.WaveCreatorTabControl.Size = new System.Drawing.Size(359, 331);
            this.WaveCreatorTabControl.TabIndex = 2;
            // 
            // PolynomialTab
            // 
            this.PolynomialTab.Controls.Add(this.groupBox1);
            this.PolynomialTab.Controls.Add(this.label3);
            this.PolynomialTab.Controls.Add(this.CreatePolynomialWaveButton);
            this.PolynomialTab.Controls.Add(this.PolynomialAmplitudeTextBox);
            this.PolynomialTab.Location = new System.Drawing.Point(4, 22);
            this.PolynomialTab.Name = "PolynomialTab";
            this.PolynomialTab.Size = new System.Drawing.Size(351, 305);
            this.PolynomialTab.TabIndex = 0;
            this.PolynomialTab.Text = "Polynomial";
            this.PolynomialTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RootViewLabel);
            this.groupBox1.Controls.Add(this.RootTrackBar);
            this.groupBox1.Controls.Add(this.DeleteRootButton);
            this.groupBox1.Controls.Add(this.AddRootButton);
            this.groupBox1.Controls.Add(this.RootsListBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 224);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roots";
            // 
            // RootViewLabel
            // 
            this.RootViewLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RootViewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RootViewLabel.Location = new System.Drawing.Point(15, 19);
            this.RootViewLabel.Name = "RootViewLabel";
            this.RootViewLabel.Size = new System.Drawing.Size(170, 125);
            this.RootViewLabel.TabIndex = 4;
            this.RootViewLabel.Text = "0";
            this.RootViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RootTrackBar
            // 
            this.RootTrackBar.Location = new System.Drawing.Point(15, 147);
            this.RootTrackBar.Name = "RootTrackBar";
            this.RootTrackBar.Size = new System.Drawing.Size(162, 45);
            this.RootTrackBar.TabIndex = 3;
            this.RootTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.RootTrackBar.Scroll += new System.EventHandler(this.RootTrackBar_Scroll);
            // 
            // DeleteRootButton
            // 
            this.DeleteRootButton.Location = new System.Drawing.Point(102, 195);
            this.DeleteRootButton.Name = "DeleteRootButton";
            this.DeleteRootButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRootButton.TabIndex = 2;
            this.DeleteRootButton.Text = "Delete Root";
            this.DeleteRootButton.UseVisualStyleBackColor = true;
            this.DeleteRootButton.Click += new System.EventHandler(this.DeleteRootButton_Click);
            // 
            // AddRootButton
            // 
            this.AddRootButton.Location = new System.Drawing.Point(15, 195);
            this.AddRootButton.Name = "AddRootButton";
            this.AddRootButton.Size = new System.Drawing.Size(75, 23);
            this.AddRootButton.TabIndex = 1;
            this.AddRootButton.Text = "Add Root";
            this.AddRootButton.UseVisualStyleBackColor = true;
            this.AddRootButton.Click += new System.EventHandler(this.AddRootButton_Click);
            // 
            // RootsListBox
            // 
            this.RootsListBox.FormattingEnabled = true;
            this.RootsListBox.Location = new System.Drawing.Point(191, 19);
            this.RootsListBox.Name = "RootsListBox";
            this.RootsListBox.Size = new System.Drawing.Size(123, 199);
            this.RootsListBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Amplitude";
            // 
            // CreatePolynomialWaveButton
            // 
            this.CreatePolynomialWaveButton.Location = new System.Drawing.Point(203, 5);
            this.CreatePolynomialWaveButton.Name = "CreatePolynomialWaveButton";
            this.CreatePolynomialWaveButton.Size = new System.Drawing.Size(120, 59);
            this.CreatePolynomialWaveButton.TabIndex = 1;
            this.CreatePolynomialWaveButton.Text = "Create Polynomial Wave";
            this.CreatePolynomialWaveButton.UseVisualStyleBackColor = true;
            this.CreatePolynomialWaveButton.Click += new System.EventHandler(this.CreatePolynomialWaveButton_Click);
            // 
            // PolynomialAmplitudeTextBox
            // 
            this.PolynomialAmplitudeTextBox.Location = new System.Drawing.Point(76, 25);
            this.PolynomialAmplitudeTextBox.Name = "PolynomialAmplitudeTextBox";
            this.PolynomialAmplitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PolynomialAmplitudeTextBox.TabIndex = 0;
            // 
            // TrigTab
            // 
            this.TrigTab.Controls.Add(this.CreateTrigWaveButton);
            this.TrigTab.Controls.Add(this.groupBox2);
            this.TrigTab.Location = new System.Drawing.Point(4, 22);
            this.TrigTab.Name = "TrigTab";
            this.TrigTab.Size = new System.Drawing.Size(351, 305);
            this.TrigTab.TabIndex = 1;
            this.TrigTab.Text = "Trigonometric";
            this.TrigTab.UseVisualStyleBackColor = true;
            // 
            // CreateTrigWaveButton
            // 
            this.CreateTrigWaveButton.Location = new System.Drawing.Point(14, 237);
            this.CreateTrigWaveButton.Name = "CreateTrigWaveButton";
            this.CreateTrigWaveButton.Size = new System.Drawing.Size(325, 43);
            this.CreateTrigWaveButton.TabIndex = 9;
            this.CreateTrigWaveButton.Text = "Create Trigonometric Wave";
            this.CreateTrigWaveButton.UseVisualStyleBackColor = true;
            this.CreateTrigWaveButton.Click += new System.EventHandler(this.CreateTrigWaveButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FrequencyTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TypeComboBox);
            this.groupBox2.Controls.Add(this.RandomnessFactorTextBox);
            this.groupBox2.Controls.Add(this.TrigAmplitudeTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(14, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 204);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // FrequencyTextBox
            // 
            this.FrequencyTextBox.Location = new System.Drawing.Point(194, 113);
            this.FrequencyTextBox.Name = "FrequencyTextBox";
            this.FrequencyTextBox.Size = new System.Drawing.Size(121, 20);
            this.FrequencyTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Randomness Factor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Frequency:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Items.AddRange(new object[] {
            "Sine",
            "Cosine"});
            this.TypeComboBox.Location = new System.Drawing.Point(194, 29);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 1;
            // 
            // RandomnessFactorTextBox
            // 
            this.RandomnessFactorTextBox.Location = new System.Drawing.Point(194, 151);
            this.RandomnessFactorTextBox.Name = "RandomnessFactorTextBox";
            this.RandomnessFactorTextBox.Size = new System.Drawing.Size(121, 20);
            this.RandomnessFactorTextBox.TabIndex = 5;
            // 
            // TrigAmplitudeTextBox
            // 
            this.TrigAmplitudeTextBox.Location = new System.Drawing.Point(194, 72);
            this.TrigAmplitudeTextBox.Name = "TrigAmplitudeTextBox";
            this.TrigAmplitudeTextBox.Size = new System.Drawing.Size(121, 20);
            this.TrigAmplitudeTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amplitude:";
            // 
            // CombinerTab
            // 
            this.CombinerTab.Controls.Add(this.CreateWaveCombinationButton);
            this.CombinerTab.Controls.Add(this.SwapWavesButton);
            this.CombinerTab.Controls.Add(this.label8);
            this.CombinerTab.Controls.Add(this.CombinerModeComboBox);
            this.CombinerTab.Controls.Add(this.RemoveWaveButton);
            this.CombinerTab.Controls.Add(this.AddWaveButton);
            this.CombinerTab.Controls.Add(this.CombinerListBox);
            this.CombinerTab.Location = new System.Drawing.Point(4, 22);
            this.CombinerTab.Name = "CombinerTab";
            this.CombinerTab.Size = new System.Drawing.Size(351, 305);
            this.CombinerTab.TabIndex = 3;
            this.CombinerTab.Text = "Combiner";
            this.CombinerTab.UseVisualStyleBackColor = true;
            // 
            // CreateWaveCombinationButton
            // 
            this.CreateWaveCombinationButton.Location = new System.Drawing.Point(17, 253);
            this.CreateWaveCombinationButton.Name = "CreateWaveCombinationButton";
            this.CreateWaveCombinationButton.Size = new System.Drawing.Size(318, 39);
            this.CreateWaveCombinationButton.TabIndex = 6;
            this.CreateWaveCombinationButton.Text = "Create";
            this.CreateWaveCombinationButton.UseVisualStyleBackColor = true;
            this.CreateWaveCombinationButton.Click += new System.EventHandler(this.CreateWaveCombinationButton_Click);
            // 
            // SwapWavesButton
            // 
            this.SwapWavesButton.Location = new System.Drawing.Point(260, 223);
            this.SwapWavesButton.Name = "SwapWavesButton";
            this.SwapWavesButton.Size = new System.Drawing.Size(75, 23);
            this.SwapWavesButton.TabIndex = 5;
            this.SwapWavesButton.Text = "Swap";
            this.SwapWavesButton.UseVisualStyleBackColor = true;
            this.SwapWavesButton.Click += new System.EventHandler(this.SwapWavesButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Combine Type:";
            // 
            // CombinerModeComboBox
            // 
            this.CombinerModeComboBox.FormattingEnabled = true;
            this.CombinerModeComboBox.Items.AddRange(new object[] {
            "Add",
            "Chain"});
            this.CombinerModeComboBox.Location = new System.Drawing.Point(140, 174);
            this.CombinerModeComboBox.Name = "CombinerModeComboBox";
            this.CombinerModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.CombinerModeComboBox.TabIndex = 3;
            // 
            // RemoveWaveButton
            // 
            this.RemoveWaveButton.Location = new System.Drawing.Point(140, 223);
            this.RemoveWaveButton.Name = "RemoveWaveButton";
            this.RemoveWaveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveWaveButton.TabIndex = 2;
            this.RemoveWaveButton.Text = "Remove";
            this.RemoveWaveButton.UseVisualStyleBackColor = true;
            this.RemoveWaveButton.Click += new System.EventHandler(this.RemoveWaveButton_Click);
            // 
            // AddWaveButton
            // 
            this.AddWaveButton.Location = new System.Drawing.Point(17, 223);
            this.AddWaveButton.Name = "AddWaveButton";
            this.AddWaveButton.Size = new System.Drawing.Size(75, 23);
            this.AddWaveButton.TabIndex = 1;
            this.AddWaveButton.Text = "Add";
            this.AddWaveButton.UseVisualStyleBackColor = true;
            this.AddWaveButton.Click += new System.EventHandler(this.AddWaveButton_Click);
            // 
            // CombinerListBox
            // 
            this.CombinerListBox.FormattingEnabled = true;
            this.CombinerListBox.Location = new System.Drawing.Point(17, 17);
            this.CombinerListBox.Name = "CombinerListBox";
            this.CombinerListBox.Size = new System.Drawing.Size(318, 134);
            this.CombinerListBox.TabIndex = 0;
            // 
            // UseWaveButton
            // 
            this.UseWaveButton.Location = new System.Drawing.Point(369, 312);
            this.UseWaveButton.Name = "UseWaveButton";
            this.UseWaveButton.Size = new System.Drawing.Size(120, 23);
            this.UseWaveButton.TabIndex = 1;
            this.UseWaveButton.Text = "Use Wave";
            this.UseWaveButton.UseVisualStyleBackColor = true;
            this.UseWaveButton.Click += new System.EventHandler(this.UseWaveButton_Click);
            // 
            // WavesListBox
            // 
            this.WavesListBox.FormattingEnabled = true;
            this.WavesListBox.Location = new System.Drawing.Point(369, 3);
            this.WavesListBox.Name = "WavesListBox";
            this.WavesListBox.Size = new System.Drawing.Size(120, 303);
            this.WavesListBox.TabIndex = 0;
            this.WavesListBox.SelectedIndexChanged += new System.EventHandler(this.OnItemSelectedChanged);
            // 
            // RenderTimer
            // 
            this.RenderTimer.Enabled = true;
            this.RenderTimer.Interval = 10;
            this.RenderTimer.Tick += new System.EventHandler(this.RenderTimer_Tick);
            // 
            // RecordModeCheckBox
            // 
            this.RecordModeCheckBox.AutoSize = true;
            this.RecordModeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RecordModeCheckBox.Location = new System.Drawing.Point(9, 169);
            this.RecordModeCheckBox.Name = "RecordModeCheckBox";
            this.RecordModeCheckBox.Size = new System.Drawing.Size(195, 35);
            this.RecordModeCheckBox.TabIndex = 2;
            this.RecordModeCheckBox.Text = "Record Mode";
            this.RecordModeCheckBox.UseVisualStyleBackColor = true;
            // 
            // IterationsTextBox
            // 
            this.IterationsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IterationsTextBox.Location = new System.Drawing.Point(210, 169);
            this.IterationsTextBox.Name = "IterationsTextBox";
            this.IterationsTextBox.Size = new System.Drawing.Size(254, 38);
            this.IterationsTextBox.TabIndex = 3;
            this.IterationsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(259, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 31);
            this.label9.TabIndex = 4;
            this.label9.Text = "Iterations";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WavePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 547);
            this.Controls.Add(this.OptionsTabControl);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.waveView);
            this.Name = "WavePlayer";
            this.Text = "WavePlayer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WavePlayer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.waveView)).EndInit();
            this.OptionsTabControl.ResumeLayout(false);
            this.SimulationTab.ResumeLayout(false);
            this.SimulationTab.PerformLayout();
            this.RendererTab.ResumeLayout(false);
            this.WaveSettingsTab.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.BasicWaveSettings.ResumeLayout(false);
            this.BasicWaveSettings.PerformLayout();
            this.WaveCreatorTabControl.ResumeLayout(false);
            this.PolynomialTab.ResumeLayout(false);
            this.PolynomialTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RootTrackBar)).EndInit();
            this.TrigTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.CombinerTab.ResumeLayout(false);
            this.CombinerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox waveView;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.TabControl OptionsTabControl;
        private System.Windows.Forms.TabPage SimulationTab;
        private System.Windows.Forms.TabPage RendererTab;
        private System.Windows.Forms.TabPage WaveSettingsTab;
        private System.Windows.Forms.ListBox WavesListBox;
        private System.Windows.Forms.Button UseWaveButton;
        private System.Windows.Forms.TabControl WaveCreatorTabControl;
        private System.Windows.Forms.TabPage PolynomialTab;
        private System.Windows.Forms.TabPage TrigTab;
        private System.Windows.Forms.TabPage CombinerTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WaveSpeedTextBox;
        private System.Windows.Forms.TextBox WaveSizeTextBox;
        private System.Windows.Forms.GroupBox BasicWaveSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PolynomialAmplitudeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar RootTrackBar;
        private System.Windows.Forms.Button DeleteRootButton;
        private System.Windows.Forms.Button AddRootButton;
        private System.Windows.Forms.ListBox RootsListBox;
        private System.Windows.Forms.Button CreatePolynomialWaveButton;
        private System.Windows.Forms.Label RootViewLabel;
        private System.Windows.Forms.Button DeleteWaveButton;
        private System.Windows.Forms.Timer RenderTimer;
        private System.Windows.Forms.Button CreateSimulationButton;
        private System.Windows.Forms.Label UsedWaveLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TrigAmplitudeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RandomnessFactorTextBox;
        private System.Windows.Forms.TextBox FrequencyTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.Button CreateTrigWaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CombinerModeComboBox;
        private System.Windows.Forms.Button RemoveWaveButton;
        private System.Windows.Forms.Button AddWaveButton;
        private System.Windows.Forms.ListBox CombinerListBox;
        private System.Windows.Forms.Button SwapWavesButton;
        private System.Windows.Forms.Button CreateWaveCombinationButton;
        private System.Windows.Forms.Button CreateZeroWaveButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox WaveSizeIndicatorTextBox;
        private System.Windows.Forms.Button SelectSecondaryColorButton;
        private System.Windows.Forms.Button SelectMainColorButton;
        private System.Windows.Forms.Button SingleColorRenderModeButton;
        private System.Windows.Forms.Button AccelerationColorModeButton;
        private System.Windows.Forms.Button VelocityColorModeButton;
        private System.Windows.Forms.Button DisplacementColorModeButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox IterationsTextBox;
        private System.Windows.Forms.CheckBox RecordModeCheckBox;
    }
}