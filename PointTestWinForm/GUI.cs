using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedPointTest;

namespace PointTestWinForm
{
    public partial class GUI : Form, SharedPointTest.ITestCaseGUI
    {
        public GUI()
        {
            InitializeComponent();
        }

        public void attachImage(Bitmap bitmap)
        {
            //throw new NotImplementedException();
            picRes.Image = bitmap;
        }

        public void attachResult(string res)
        {
            //throw new NotImplementedException();
            rtbRes.Text += res + "\n";

            //rtbRes.Text += "test completed\n";

        }

        public void beginTesting(string testContent)
        {
            rtbRes.Text += "Testing " + testContent + " class...\n";
        }

        public void endTesting()
        {
            rtbRes.Text += "test completed\n\n";
        }
    }
}
