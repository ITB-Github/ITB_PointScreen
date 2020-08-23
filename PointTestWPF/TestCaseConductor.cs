using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SharedPointTest
{
    public delegate ImageSource ImageWPFTest();
    public delegate void UIwpfTest();
    public partial class TestCaseConductor
    {
        public virtual void ConductTest(ImageSource res, string className, string funcName)
        {
            _igui.beginTesting(className);
            _igui.attachImage(res);
            _igui.endTesting();
        }

        public virtual void ConductTest(UIwpfTest uiTest, string className, string funcName)
        {
            _igui.beginTesting(className);
            uiTest();
            _igui.endTesting();
        }
    }
}
