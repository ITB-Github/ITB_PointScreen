using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointTestWPF
{
    internal class TeamChosenWindowTestCase
    {
        PointViewWPF.TeamChosenView gui;
        public TeamChosenWindowTestCase()
        {
            gui = new PointViewWPF.TeamChosenView();
        }
        public void PerformDirtyTest()
        {
            gui.Show();
        }
    }
}
