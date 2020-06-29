using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hair_by_Visage_Payroll_System
{
    public static class information
    {
        public static string ID;
        public static double GrossPay;
        public static string Worked;
        //Declaring a global variable 
    }




    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Hair_by_Visage_Payroll_System.LogIn());
        }
    }
}


