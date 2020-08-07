namespace BMI_Calculator
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashLabel = new System.Windows.Forms.Label();
            this.SplashFormtimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashLabel
            // 
            this.SplashLabel.AutoSize = true;
            this.SplashLabel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SplashLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SplashLabel.Location = new System.Drawing.Point(34, 387);
            this.SplashLabel.Name = "SplashLabel";
            this.SplashLabel.Size = new System.Drawing.Size(255, 31);
            this.SplashLabel.TabIndex = 0;
            this.SplashLabel.Text = "BMI Calculator App!";
            this.SplashLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SplashLabel.Click += new System.EventHandler(this.SplashLabel_Click);
            // 
            // SplashFormtimer
            // 
            this.SplashFormtimer.Enabled = true;
            this.SplashFormtimer.Interval = 3000;
            this.SplashFormtimer.Tick += new System.EventHandler(this.SplashFormtimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.ControlBox = false;
            this.Controls.Add(this.SplashLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SplashLabel;
        private System.Windows.Forms.Timer SplashFormtimer;
    }
}