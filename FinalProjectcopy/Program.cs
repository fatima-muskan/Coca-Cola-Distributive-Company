using FinalProject.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    internal static class Program
    {
      
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            EmployeeDL BST = new EmployeeDL();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (BST.read("Employee.csv"))
            {
                Application.Run(new loginForm());
            } 
        }
    }
}
