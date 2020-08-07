using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public static class Program
    {
        /*The Author's name: Jiyeon Jeon
        Author's student number: #301103064
        Date last Modified: August 7, 2020
        Program description: BMI Calculator App
        Revision History: 1.0 created August 5, 2020 Jiyeon 
        */


        public static SplashForm splashForm;
        public static BMICalculatorForm bmicalculatorForm;
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            bmicalculatorForm = new BMICalculatorForm();

            Application.Run(splashForm);
            Application.Run(bmicalculatorForm);
        }
    }
}
