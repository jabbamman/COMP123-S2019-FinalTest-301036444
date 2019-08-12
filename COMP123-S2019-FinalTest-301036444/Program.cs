using COMP123_S2019_FinalTest_301036444.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
