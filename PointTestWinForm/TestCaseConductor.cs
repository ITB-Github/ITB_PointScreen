using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedPointTest;

namespace SharedPointTest
{
    //public delegate bool BoolTest();
    public delegate Bitmap BitmapTest();
    public partial class TestCaseConductor
    {

        //private ITestCaseGUI _igui;
        public virtual void ConductTest(Bitmap res, string className, string funcName)
        {
            _igui.beginTesting(className);
            _igui.attachImage(res);
            _igui.endTesting();
        }
    }
}
