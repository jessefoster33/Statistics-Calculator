namespace Statistics_Calculator_Assignment_3
{
    partial class StatisticsCalculatorForm
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
            this.quitButton = new System.Windows.Forms.Button();
            this.datasetGroup = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.datasetTextbox = new System.Windows.Forms.TextBox();
            this.statsGroup = new System.Windows.Forms.GroupBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.medianTextbox = new System.Windows.Forms.TextBox();
            this.meanTextbox = new System.Windows.Forms.TextBox();
            this.rangeTextbox = new System.Windows.Forms.TextBox();
            this.maxValueTextbox = new System.Windows.Forms.TextBox();
            this.minValueTextbox = new System.Windows.Forms.TextBox();
            this.medianLabel = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.rangeLabel = new System.Windows.Forms.Label();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.histrogramGroup = new System.Windows.Forms.GroupBox();
            this.histogramTextbox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.datasetGroup.SuspendLayout();
            this.statsGroup.SuspendLayout();
            this.histrogramGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(805, 625);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(102, 33);
            this.quitButton.TabIndex = 18;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // datasetGroup
            // 
            this.datasetGroup.Controls.Add(this.saveButton);
            this.datasetGroup.Controls.Add(this.loadButton);
            this.datasetGroup.Controls.Add(this.datasetTextbox);
            this.datasetGroup.Location = new System.Drawing.Point(33, 32);
            this.datasetGroup.Name = "datasetGroup";
            this.datasetGroup.Size = new System.Drawing.Size(369, 581);
            this.datasetGroup.TabIndex = 19;
            this.datasetGroup.TabStop = false;
            this.datasetGroup.Text = "Data Set";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(228, 102);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(111, 46);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save Data";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(228, 25);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(111, 45);
            this.loadButton.TabIndex = 19;
            this.loadButton.Text = "Load Data";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // datasetTextbox
            // 
            this.datasetTextbox.Location = new System.Drawing.Point(33, 23);
            this.datasetTextbox.Multiline = true;
            this.datasetTextbox.Name = "datasetTextbox";
            this.datasetTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datasetTextbox.Size = new System.Drawing.Size(154, 533);
            this.datasetTextbox.TabIndex = 18;
            this.datasetTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DatasetTextbox_KeyPress);
            // 
            // statsGroup
            // 
            this.statsGroup.Controls.Add(this.calculateButton);
            this.statsGroup.Controls.Add(this.medianTextbox);
            this.statsGroup.Controls.Add(this.meanTextbox);
            this.statsGroup.Controls.Add(this.rangeTextbox);
            this.statsGroup.Controls.Add(this.maxValueTextbox);
            this.statsGroup.Controls.Add(this.minValueTextbox);
            this.statsGroup.Controls.Add(this.medianLabel);
            this.statsGroup.Controls.Add(this.meanLabel);
            this.statsGroup.Controls.Add(this.rangeLabel);
            this.statsGroup.Controls.Add(this.maximumLabel);
            this.statsGroup.Controls.Add(this.minimumLabel);
            this.statsGroup.Location = new System.Drawing.Point(421, 32);
            this.statsGroup.Name = "statsGroup";
            this.statsGroup.Size = new System.Drawing.Size(486, 252);
            this.statsGroup.TabIndex = 20;
            this.statsGroup.TabStop = false;
            this.statsGroup.Text = "Statistics";
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Location = new System.Drawing.Point(9, 29);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(143, 85);
            this.calculateButton.TabIndex = 28;
            this.calculateButton.Text = "Calculate Statistics";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // medianTextbox
            // 
            this.medianTextbox.Location = new System.Drawing.Point(377, 208);
            this.medianTextbox.Name = "medianTextbox";
            this.medianTextbox.ReadOnly = true;
            this.medianTextbox.Size = new System.Drawing.Size(100, 26);
            this.medianTextbox.TabIndex = 27;
            // 
            // meanTextbox
            // 
            this.meanTextbox.Location = new System.Drawing.Point(377, 156);
            this.meanTextbox.Name = "meanTextbox";
            this.meanTextbox.ReadOnly = true;
            this.meanTextbox.Size = new System.Drawing.Size(100, 26);
            this.meanTextbox.TabIndex = 26;
            // 
            // rangeTextbox
            // 
            this.rangeTextbox.Location = new System.Drawing.Point(377, 108);
            this.rangeTextbox.Name = "rangeTextbox";
            this.rangeTextbox.ReadOnly = true;
            this.rangeTextbox.Size = new System.Drawing.Size(100, 26);
            this.rangeTextbox.TabIndex = 25;
            // 
            // maxValueTextbox
            // 
            this.maxValueTextbox.Location = new System.Drawing.Point(377, 55);
            this.maxValueTextbox.Name = "maxValueTextbox";
            this.maxValueTextbox.ReadOnly = true;
            this.maxValueTextbox.Size = new System.Drawing.Size(100, 26);
            this.maxValueTextbox.TabIndex = 24;
            // 
            // minValueTextbox
            // 
            this.minValueTextbox.Location = new System.Drawing.Point(377, 6);
            this.minValueTextbox.Name = "minValueTextbox";
            this.minValueTextbox.ReadOnly = true;
            this.minValueTextbox.Size = new System.Drawing.Size(100, 26);
            this.minValueTextbox.TabIndex = 23;
            // 
            // medianLabel
            // 
            this.medianLabel.AutoSize = true;
            this.medianLabel.Location = new System.Drawing.Point(288, 214);
            this.medianLabel.Name = "medianLabel";
            this.medianLabel.Size = new System.Drawing.Size(61, 20);
            this.medianLabel.TabIndex = 22;
            this.medianLabel.Text = "Median";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Location = new System.Drawing.Point(300, 162);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(49, 20);
            this.meanLabel.TabIndex = 21;
            this.meanLabel.Text = "Mean";
            // 
            // rangeLabel
            // 
            this.rangeLabel.AutoSize = true;
            this.rangeLabel.Location = new System.Drawing.Point(292, 114);
            this.rangeLabel.Name = "rangeLabel";
            this.rangeLabel.Size = new System.Drawing.Size(57, 20);
            this.rangeLabel.TabIndex = 20;
            this.rangeLabel.Text = "Range";
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(228, 61);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(121, 20);
            this.maximumLabel.TabIndex = 19;
            this.maximumLabel.Text = "Maximum Value";
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Location = new System.Drawing.Point(232, 9);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(117, 20);
            this.minimumLabel.TabIndex = 18;
            this.minimumLabel.Text = "Minimum Value";
            // 
            // histrogramGroup
            // 
            this.histrogramGroup.Controls.Add(this.histogramTextbox);
            this.histrogramGroup.Location = new System.Drawing.Point(421, 302);
            this.histrogramGroup.Name = "histrogramGroup";
            this.histrogramGroup.Size = new System.Drawing.Size(486, 311);
            this.histrogramGroup.TabIndex = 21;
            this.histrogramGroup.TabStop = false;
            this.histrogramGroup.Text = "Histogram";
            // 
            // histogramTextbox
            // 
            this.histogramTextbox.Location = new System.Drawing.Point(9, 25);
            this.histogramTextbox.Multiline = true;
            this.histogramTextbox.Name = "histogramTextbox";
            this.histogramTextbox.ReadOnly = true;
            this.histogramTextbox.Size = new System.Drawing.Size(468, 268);
            this.histogramTextbox.TabIndex = 10;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(673, 625);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(111, 33);
            this.resetButton.TabIndex = 21;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // StatisticsCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 680);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.histrogramGroup);
            this.Controls.Add(this.statsGroup);
            this.Controls.Add(this.datasetGroup);
            this.Controls.Add(this.quitButton);
            this.Name = "StatisticsCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics Calculator";
            this.datasetGroup.ResumeLayout(false);
            this.datasetGroup.PerformLayout();
            this.statsGroup.ResumeLayout(false);
            this.statsGroup.PerformLayout();
            this.histrogramGroup.ResumeLayout(false);
            this.histrogramGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox datasetTextbox;
        private System.Windows.Forms.GroupBox statsGroup;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox medianTextbox;
        private System.Windows.Forms.TextBox meanTextbox;
        private System.Windows.Forms.TextBox rangeTextbox;
        private System.Windows.Forms.TextBox maxValueTextbox;
        private System.Windows.Forms.TextBox minValueTextbox;
        private System.Windows.Forms.Label medianLabel;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label rangeLabel;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.Label minimumLabel;
        private System.Windows.Forms.GroupBox histrogramGroup;
        private System.Windows.Forms.TextBox histogramTextbox;
        public System.Windows.Forms.GroupBox datasetGroup;
        private System.Windows.Forms.Button resetButton;
    }
}

