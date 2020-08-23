using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedPointTest;

namespace PointTestWinForm
{
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

            GUI gui = new GUI();

            BitmapTest fnc;

            ITestCaseGUI igui = (ITestCaseGUI)gui;
            TestCaseConductor conductor = new TestCaseConductor(igui);

            var testCase = new FullScreenTestCase();
            fnc = testCase.PrimaryScreenTest;
            conductor.ConductTest(fnc(), testCase.GetType().Name, fnc.Method.Name);


            
            
            
            Application.Run(gui);
        }
    }
}
