using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SharedPointTest
{
    public partial  interface ITestCaseGUI
    {
        void beginTesting(string testContent);
        void attachResult(string res);
        //void attachImage(Bitmap bitmap);
        //void attachImage(Bitmap bitmap);
        void endTesting();
    }
}
