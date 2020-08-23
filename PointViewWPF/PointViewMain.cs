using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using PointPresenterController;

namespace PointViewWPF
{
    public class PointViewMain
    {
        private MainWindow _pv;
        private TeamChosenView _tv;
        private PreviewView _prv;
        private HotkeyView _hkv;

        public PointViewMain()
        {
            _pv = new MainWindow();
            _tv = new TeamChosenView();
            _prv = new PreviewView();
            _hkv = new HotkeyView();

            _pv.AttachHotkeyView(_hkv);

        }

        public PointViewModel GetPointViewModel()
        {
            return _pv.DataContext as PointViewModel;
        }

        public TeamChosenViewModel GetTeamChosenViewModel()
        {
            return _tv.DataContext as TeamChosenViewModel;
        }
        public PreviewViewModel GetPreviewViewModel()
        {
            return _prv.DataContext as PreviewViewModel;
        }

        public Window GetMainWindow()
        {
            return _pv as Window;
        }

    }
}
