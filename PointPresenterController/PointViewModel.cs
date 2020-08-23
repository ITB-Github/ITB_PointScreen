using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
//using System.Windows;

namespace PointPresenterController
{
    //public delegate void ClickHandler(object sender, RoutedEventArgs e);
    public class PointViewModel: ViewModelBase
    {

        IController _iCtrl;
        public PointViewModel()
        {
            Id = null;
            TeamName = "Tên Đội";
            Point = 0;

            WinState = WindowState.Normal;
            Left = 0;
            Top = 0;


            //FullScreenCMD = new MakeFullScreenCMD(DoMakeFullScren);
        }
        public void AttachController(IController iCtrl)
        {
            _iCtrl = iCtrl;
            //
            //
            //FullScreenCMD.ICtrl = iCtrl;
        }
        /// <summary>
        /// Property
        /// </summary>
        string _Id;
        public string Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
                RaisePropertyChanged("Id");
            }
        }

        string _TeamName;
        public string TeamName
        {
            get
            {
                return _TeamName;
            }
            set
            {
                _TeamName = value;
                RaisePropertyChanged("TeamName");
            }
        }

        int _Point;
        public int Point
        {
            get
            {
                return _Point;
            }
            set
            {
                _Point = value;
                RaisePropertyChanged("Point");
            }
        }

        WindowState _winState;
        public WindowState WinState
        {
            get
            {
                return _winState;
            }
            set
            {
                _winState = value;
                RaisePropertyChanged("WinState");
            }
        }

        int _Left;
        public int Left
        {
            get
            {
                return _Left;
            }
            set
            {
                _Left = value;
                RaisePropertyChanged("Left");
            }
        }

        int _Top;
        public int Top
        {
            get
            {
                return _Top;
            }
            set
            {
                _Top = value;
                RaisePropertyChanged("Top");
            }
        }


        ImageSource _Landing;
        public ImageSource Landing
        {
            get
            {
                return _Landing;
            }
            set
            {
                _Landing = value;
                RaisePropertyChanged("Landing");
            }
        }

        ///Command
        ///
        public void MakeFullScreen()
        {
                if (_iCtrl == null)
                {
                    //MessageBox.Show("Please Attach Controller");
                    return;
                }    
                    
                _iCtrl.GetScreenShot();

        }

        public void GetTeamToChoose()
        {
            if(_iCtrl==null)
            {
                return;
            }
            _iCtrl.GetTeamsToChoose();
        }
        //private MakeFullScreenCMD _FullScreenCMD;
        //public MakeFullScreenCMD FullScreenCMD
        //{
        //    get
        //    {
        //        return _FullScreenCMD;
        //    }
        //    set
        //    {
        //        _FullScreenCMD = value;

        //    }
        //}


        //private void DoMakeFullScren(object parameter)
        //{
        //    if (_iCtrl == null)
        //        return;
        //    _iCtrl.GetScreenShot();
        //}


    }


}
