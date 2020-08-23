using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointInteractor;
using PointInteractor.OutputData;

namespace PointPresenterController
{
    internal class Presenter : OutputBoundary
    {
        /// <summary>
        /// Phần Variable
        /// </summary>
        /// <param></param>
        /// 
        TeamChosenViewModel _tmv;
        PointViewModel _pvm;
        PreviewViewModel _prvm;
        public Presenter(TeamChosenViewModel tvm, PointViewModel pvm, PreviewViewModel prvm)
        {
            //_tmv = new TeamChosenViewModel();
            //_pvm = new PointViewModel();
            //_prvm = new PreviewViewModel();

            _tmv = tvm;
            _pvm = pvm;
            _prvm = prvm;
        }

        /// <summary>
        /// Phần Interface
        /// </summary>
        /// <param></param>
        public void ReceiveLauncher(LauncherOutData img)
        {
            _pvm.Landing = Converter.ByteToImage(img.Launcher);
            //throw new NotImplementedException();
        }

        public void ReceiveTeams(List<TeamOutData> datas)
        {
            _tmv.Teams = new System.Collections.ObjectModel.ObservableCollection<TeamViewModel>();
            foreach(TeamOutData data in datas)
            {
                TeamViewModel tvm = new TeamViewModel(
                    data.Id,
                    data.TeamName,
                    data.Point);

                _tmv.Teams.Add(tvm);
            }
            _tmv.Visibility = System.Windows.Visibility.Visible;
            //throw new NotImplementedException();
        }

        public void ReceiveTheTeam(TeamOutData data)
        {
            _pvm.Id = data.Id;
            _pvm.TeamName = data.TeamName;
            _pvm.Point = data.Point;
            //throw new NotImplementedException();
        }

        public void RecieveFullScreenInstruction(ScreenOutInstruction instruction)
        {
            //throw new NotImplementedException();


            _pvm.Top = instruction.Top;
            _pvm.Left = instruction.Left;
            
            if(instruction.IsMaximized)
            {
                _pvm.WinState = System.Windows.WindowState.Maximized;
            }    
        }

        public void RecieveScreens(List<ScreenOutData> scr)
        {
            

            _prvm.Screens = new System.Collections.ObjectModel.ObservableCollection<ScreenViewModel>();
            foreach(var screen in scr)
            {
                ScreenViewModel scrvm = new ScreenViewModel(
                    screen.Id, 
                    Converter.ByteToImage(screen.ScreenShot));

                _prvm.Screens.Add(scrvm);
            }

            _prvm.Visible = System.Windows.Visibility.Visible;
            //throw new NotImplementedException();
        }
    }
}
