using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SharedPointTest;

namespace PointTestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, SharedPointTest.ITestCaseGUI
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        public void attachImage(ImageSource bitmap)
        {
            //throw new NotImplementedException();
            picRes.Source = bitmap;
        }

        public void attachResult(string res)
        {
            txbRes.AppendText("\n"+res);
            //throw new NotImplementedException();
        }

        public void beginTesting(string testContent)
        {
            txbRes.AppendText("\nBegin Testing");
        }

        public void endTesting()
        {
            //throw new NotImplementedException();
            txbRes.AppendText("\nEnd Testing");
        }
    }
}
