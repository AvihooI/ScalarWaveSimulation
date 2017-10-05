namespace ScalarWaveSimulation.Comparison
{
    partial class ScalarWaveComparison
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
            this.ComparisonView = new System.Windows.Forms.PictureBox();
            this.ComparisonTimer = new System.Windows.Forms.Timer(this.components);
            this.AutoIncrementCheckbox = new System.Windows.Forms.CheckBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.TimeTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComparisonView)).BeginInit();
            this.SuspendLayout();
            // 
            // ComparisonView
            // 
            this.ComparisonView.Location = new System.Drawing.Point(145, 12);
            this.ComparisonView.Name = "ComparisonView";
            this.ComparisonView.Size = new System.Drawing.Size(500, 500);
            this.ComparisonView.TabIndex = 0;
            this.ComparisonView.TabStop = false;
            this.ComparisonView.Paint += new System.Windows.Forms.PaintEventHandler(this.ComparisonView_Paint);
            // 
            // ComparisonTimer
            // 
            this.ComparisonTimer.Enabled = true;
            this.ComparisonTimer.Interval = 1;
            this.ComparisonTimer.Tick += new System.EventHandler(this.ComparisonTimer_Tick);
            // 
            // AutoIncrementCheckbox
            // 
            this.AutoIncrementCheckbox.AutoSize = true;
            this.AutoIncrementCheckbox.Location = new System.Drawing.Point(564, 519);
            this.AutoIncrementCheckbox.Name = "AutoIncrementCheckbox";
            this.AutoIncrementCheckbox.Size = new System.Drawing.Size(98, 17);
            this.AutoIncrementCheckbox.TabIndex = 1;
            this.AutoIncrementCheckbox.Text = "Auto Increment";
            this.AutoIncrementCheckbox.UseVisualStyleBackColor = true;
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(145, 513);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // TimeTextBox
            // 
            this.TimeTextBox.Location = new System.Drawing.Point(226, 513);
            this.TimeTextBox.Name = "TimeTextBox";
            this.TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.TimeTextBox.TabIndex = 3;
            // 
            // ScalarWaveComparison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.TimeTextBox);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.AutoIncrementCheckbox);
            this.Controls.Add(this.ComparisonView);
            this.Name = "ScalarWaveComparison";
            this.Text = "Comparison Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.ComparisonView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ComparisonView;
        private System.Windows.Forms.Timer ComparisonTimer;
        private System.Windows.Forms.CheckBox AutoIncrementCheckbox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TextBox TimeTextBox;
    }
}

