namespace LAB1
{
    partial class BackBagForm
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
            this.runButton = new System.Windows.Forms.Button();
            this.fullWeightInput = new System.Windows.Forms.TextBox();
            this.fullWeigthLabel = new System.Windows.Forms.Label();
            this.seedInput = new System.Windows.Forms.TextBox();
            this.seedLabel = new System.Windows.Forms.Label();
            this.numberOfItemsInput = new System.Windows.Forms.TextBox();
            this.numberOfItemsLabel = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.finalFullWeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.finalFullValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(524, 30);
            this.runButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(100, 28);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fullWeightInput
            // 
            this.fullWeightInput.Location = new System.Drawing.Point(17, 32);
            this.fullWeightInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullWeightInput.Name = "fullWeightInput";
            this.fullWeightInput.Size = new System.Drawing.Size(132, 22);
            this.fullWeightInput.TabIndex = 1;
            this.fullWeightInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // fullWeigthLabel
            // 
            this.fullWeigthLabel.AutoSize = true;
            this.fullWeigthLabel.Location = new System.Drawing.Point(13, 15);
            this.fullWeigthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullWeigthLabel.Name = "fullWeigthLabel";
            this.fullWeigthLabel.Size = new System.Drawing.Size(107, 16);
            this.fullWeigthLabel.TabIndex = 2;
            this.fullWeigthLabel.Text = "Enter Full Weigth";
            // 
            // seedInput
            // 
            this.seedInput.Location = new System.Drawing.Point(192, 33);
            this.seedInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seedInput.Name = "seedInput";
            this.seedInput.Size = new System.Drawing.Size(132, 22);
            this.seedInput.TabIndex = 3;
            // 
            // seedLabel
            // 
            this.seedLabel.AutoSize = true;
            this.seedLabel.Location = new System.Drawing.Point(188, 15);
            this.seedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seedLabel.Name = "seedLabel";
            this.seedLabel.Size = new System.Drawing.Size(72, 16);
            this.seedLabel.TabIndex = 4;
            this.seedLabel.Text = "Enter seed";
            // 
            // numberOfItemsInput
            // 
            this.numberOfItemsInput.Location = new System.Drawing.Point(359, 34);
            this.numberOfItemsInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numberOfItemsInput.Name = "numberOfItemsInput";
            this.numberOfItemsInput.Size = new System.Drawing.Size(132, 22);
            this.numberOfItemsInput.TabIndex = 5;
            // 
            // numberOfItemsLabel
            // 
            this.numberOfItemsLabel.AutoSize = true;
            this.numberOfItemsLabel.Location = new System.Drawing.Point(355, 15);
            this.numberOfItemsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numberOfItemsLabel.Name = "numberOfItemsLabel";
            this.numberOfItemsLabel.Size = new System.Drawing.Size(135, 16);
            this.numberOfItemsLabel.TabIndex = 6;
            this.numberOfItemsLabel.Text = "Enter number of items";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(17, 87);
            this.result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.Size = new System.Drawing.Size(269, 296);
            this.result.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Picked items";
            // 
            // finalFullWeight
            // 
            this.finalFullWeight.Location = new System.Drawing.Point(325, 112);
            this.finalFullWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finalFullWeight.Name = "finalFullWeight";
            this.finalFullWeight.ReadOnly = true;
            this.finalFullWeight.Size = new System.Drawing.Size(132, 22);
            this.finalFullWeight.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "BackBag final weight";
            // 
            // finalFullValue
            // 
            this.finalFullValue.Location = new System.Drawing.Point(325, 164);
            this.finalFullValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.finalFullValue.Name = "finalFullValue";
            this.finalFullValue.ReadOnly = true;
            this.finalFullValue.Size = new System.Drawing.Size(132, 22);
            this.finalFullValue.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "BackBag final value";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(325, 354);
            this.resetButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 28);
            this.resetButton.TabIndex = 13;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // BackBagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 399);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finalFullValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.finalFullWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.numberOfItemsLabel);
            this.Controls.Add(this.numberOfItemsInput);
            this.Controls.Add(this.seedLabel);
            this.Controls.Add(this.seedInput);
            this.Controls.Add(this.fullWeigthLabel);
            this.Controls.Add(this.fullWeightInput);
            this.Controls.Add(this.runButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BackBagForm";
            this.Text = "BackBagForm";
            this.Load += new System.EventHandler(this.BackBagForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox fullWeightInput;
        private System.Windows.Forms.Label fullWeigthLabel;
        private System.Windows.Forms.TextBox seedInput;
        private System.Windows.Forms.Label seedLabel;
        private System.Windows.Forms.TextBox numberOfItemsInput;
        private System.Windows.Forms.Label numberOfItemsLabel;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox finalFullWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox finalFullValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button resetButton;
    }
}