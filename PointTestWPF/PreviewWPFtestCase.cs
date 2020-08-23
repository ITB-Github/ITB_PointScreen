using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTestWPF
{
    internal class PreviewWPFtestCase
    {
        PointViewWPF.PreviewView gui;
        public PreviewWPFtestCase()
        {
            gui = new PointViewWPF.PreviewView();
        }
        public void PerformDirtyTest()
        {
            gui.Show();
        }
    }
}
