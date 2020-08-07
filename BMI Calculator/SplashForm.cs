using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormtimer_Tick(object sender, EventArgs e)
        {
            Program.bmicalculatorForm.Show();
            this.Hide();
            SplashFormtimer.Enabled = false;
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            SplashFormtimer.Enabled = true;
        }
    }
}
