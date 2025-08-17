using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esemka_School_Library
{
    internal static class Program
    {

        public static Stack<Form> formHistory = new Stack<Form>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        

         
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Form());
        }
    }
}
