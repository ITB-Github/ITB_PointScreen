using System;
using System.Collections.Generic;
using System.Text;
using SharedPointTest;

namespace SharedPointTest
{
    public delegate bool BoolTest();
    public delegate string StringTest();
    public partial class TestCaseConductor
    {
       
        private ITestCaseGUI _igui;
        public TestCaseConductor(ITestCaseGUI gui)
        {
            _igui = gui;
        }
        public virtual void ConductTest(bool res, string className, string funcName)
        {
            _igui.beginTesting(className);
            if (res)
            {
                _igui.attachResult(funcName + " success");
            }
            else
            {
                _igui.attachResult(funcName + " failed");
            }
            _igui.endTesting();
        }

        public virtual void ConductTest(string res, string className, string funcName)
        {
            _igui.beginTesting(className);
            _igui.attachResult(res);
            _igui.endTesting();
        }
    }
}
