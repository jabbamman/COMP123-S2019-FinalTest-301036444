using COMP123_S2019_FinalTest_301036444.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Student Name: Mohamed A. Ali 
 * Student ID: 301036444
 * Description: This is the driver class for the application
 * 
 */
namespace COMP123_S2019_FinalTest_301036444
{
    public static class Program
    {
        public static CharacterGenerator characterGenerator;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            characterGenerator = new CharacterGenerator();
            Application.Run(characterGenerator);
        }
    }
}
