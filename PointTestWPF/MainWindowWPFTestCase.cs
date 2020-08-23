using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointViewWPF;
namespace PointTestWPF
{
    internal class MainWindowWPFTestCase
    {
        PointViewWPF.MainWindow gui;
        public MainWindowWPFTestCase()
        {
            gui = new PointViewWPF.MainWindow();
        }
        public void PerformDirtyTest()
        {
            gui.Show();
        }
    }
}
