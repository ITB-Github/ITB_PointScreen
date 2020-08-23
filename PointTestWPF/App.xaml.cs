using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using SharedPointTest;

namespace PointTestWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            var application = new App();
            //application.InitializeComponent();

            Window gui = new MainWindow();
            ITestCaseGUI igui = (ITestCaseGUI)gui;

            TestCaseConductor conductor = new TestCaseConductor(igui);
            
            var testCase = new FullScreenImplementationTestCase();

            ImageWPFTest fnc;
            fnc = testCase.PrimaryScreenTest;
            conductor.ConductTest(fnc(), testCase.GetType().Name, fnc.Method.Name);

            StringTest strFnc;
            strFnc = testCase.GetScreenInstructionTest;
            conductor.ConductTest(strFnc(), testCase.GetType().Name, strFnc.Method.Name);

            UIwpfTest uiTest;
            uiTest = testCase.DoScreenInstructionTest;
            conductor.ConductTest(uiTest, testCase.GetType().Name, uiTest.Method.Name);

            MainWindowWPFTestCase testCaseWPFMain = new MainWindowWPFTestCase();
            uiTest = testCaseWPFMain.PerformDirtyTest;
            conductor.ConductTest(uiTest, testCaseWPFMain.GetType().Name, uiTest.Method.Name);

            TeamChosenWindowTestCase testCaseWPFTeamChosen = new TeamChosenWindowTestCase();
            uiTest = testCaseWPFTeamChosen.PerformDirtyTest;
            conductor.ConductTest(uiTest, testCaseWPFTeamChosen.GetType().Name, uiTest.Method.Name);

            PreviewWPFtestCase previewTestCase = new PreviewWPFtestCase();
            uiTest = previewTestCase.PerformDirtyTest;
            conductor.ConductTest(uiTest, previewTestCase.GetType().Name, uiTest.Method.Name);

            application.Run(gui);
        }
    }
}
