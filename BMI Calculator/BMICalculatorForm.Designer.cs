namespace BMI_Calculator
{
    partial class BMICalculatorForm
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
            this.HeightLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.radioImperial = new System.Windows.Forms.RadioButton();
            this.radioMetric = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BMIResultLabel = new System.Windows.Forms.Label();
            this.BMIResult = new System.Windows.Forms.TextBox();
            this.BMIScaleLabel = new System.Windows.Forms.Label();
            this.ResultGroup = new System.Windows.Forms.GroupBox();
            this.BMIScale = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.ResultGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(136, 31);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "My Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(87, 199);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(143, 39);
            this.CalculateBMIButton.TabIndex = 2;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 50);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(141, 31);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "My Weight";
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(155, 3);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(138, 38);
            this.HeightInput.TabIndex = 4;
            // 
            // WeightInput
            // 
            this.WeightInput.Location = new System.Drawing.Point(155, 53);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(138, 38);
            this.WeightInput.TabIndex = 5;
            // 
            // radioImperial
            // 
            this.radioImperial.AutoSize = true;
            this.radioImperial.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioImperial.Location = new System.Drawing.Point(31, 40);
            this.radioImperial.Name = "radioImperial";
            this.radioImperial.Size = new System.Drawing.Size(123, 37);
            this.radioImperial.TabIndex = 6;
            this.radioImperial.TabStop = true;
            this.radioImperial.Text = "Imperial";
            this.radioImperial.UseVisualStyleBackColor = true;
            // 
            // radioMetric
            // 
            this.radioMetric.AutoSize = true;
            this.radioMetric.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMetric.Location = new System.Drawing.Point(166, 40);
            this.radioMetric.Name = "radioMetric";
            this.radioMetric.Size = new System.Drawing.Size(104, 37);
            this.radioMetric.TabIndex = 7;
            this.radioMetric.TabStop = true;
            this.radioMetric.Text = "Metric";
            this.radioMetric.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.HeightInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightInput, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 100);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // BMIResultLabel
            // 
            this.BMIResultLabel.AutoSize = true;
            this.BMIResultLabel.Location = new System.Drawing.Point(25, 38);
            this.BMIResultLabel.Name = "BMIResultLabel";
            this.BMIResultLabel.Size = new System.Drawing.Size(62, 31);
            this.BMIResultLabel.TabIndex = 9;
            this.BMIResultLabel.Text = "BMI";
            // 
            // BMIResult
            // 
            this.BMIResult.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BMIResult.Location = new System.Drawing.Point(112, 34);
            this.BMIResult.Name = "BMIResult";
            this.BMIResult.ReadOnly = true;
            this.BMIResult.Size = new System.Drawing.Size(181, 38);
            this.BMIResult.TabIndex = 10;
            // 
            // BMIScaleLabel
            // 
            this.BMIScaleLabel.AutoSize = true;
            this.BMIScaleLabel.Location = new System.Drawing.Point(17, 89);
            this.BMIScaleLabel.Name = "BMIScaleLabel";
            this.BMIScaleLabel.Size = new System.Drawing.Size(82, 31);
            this.BMIScaleLabel.TabIndex = 11;
            this.BMIScaleLabel.Text = "Scale";
            // 
            // ResultGroup
            // 
            this.ResultGroup.Controls.Add(this.BMIScale);
            this.ResultGroup.Controls.Add(this.BMIScaleLabel);
            this.ResultGroup.Controls.Add(this.BMIResult);
            this.ResultGroup.Controls.Add(this.BMIResultLabel);
            this.ResultGroup.Location = new System.Drawing.Point(0, 245);
            this.ResultGroup.Name = "ResultGroup";
            this.ResultGroup.Size = new System.Drawing.Size(304, 153);
            this.ResultGroup.TabIndex = 12;
            this.ResultGroup.TabStop = false;
            this.ResultGroup.Text = "Result";
            // 
            // BMIScale
            // 
            this.BMIScale.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BMIScale.Location = new System.Drawing.Point(112, 87);
            this.BMIScale.Name = "BMIScale";
            this.BMIScale.ReadOnly = true;
            this.BMIScale.Size = new System.Drawing.Size(180, 38);
            this.BMIScale.TabIndex = 12;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(202, 400);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 41);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.WelcomeLabel.Location = new System.Drawing.Point(81, 5);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(159, 34);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "BMI Calculator";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResultGroup);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.radioMetric);
            this.Controls.Add(this.radioImperial);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator App";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResultGroup.ResumeLayout(false);
            this.ResultGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.RadioButton radioImperial;
        private System.Windows.Forms.RadioButton radioMetric;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label BMIResultLabel;
        private System.Windows.Forms.TextBox BMIResult;
        private System.Windows.Forms.Label BMIScaleLabel;
        private System.Windows.Forms.GroupBox ResultGroup;
        private System.Windows.Forms.TextBox BMIScale;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}

