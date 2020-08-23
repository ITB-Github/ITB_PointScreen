using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PointPresenterController
{
    public class TeamChosenViewModel: ViewModelBase
    {
        IController _iCtrl;
        ObservableCollection<TeamViewModel> _Teams;
        public ObservableCollection<TeamViewModel> Teams
        {
            get
            {
                return _Teams; 
            }
            set
            {
                _Teams = value;
                RaisePropertyChanged("Teams");
            }
        }

        public Visibility Visibility
        {
            get
            {
                if(Designer.IsDesignMode)
                {
                    return Visibility.Visible;
                }    
                return _Visibility; 
            }
            set
            {
                _Visibility = value;
                RaisePropertyChanged("Visibility");
            }
        }

        Visibility _Visibility;
        public void AttachController(IController iCtrl)
        {
            _iCtrl = iCtrl;
        }
        public TeamChosenViewModel()
        {
            _Teams = new ObservableCollection<TeamViewModel>();
            TeamViewModel teamNotSet = new TeamViewModel();
            _Teams.Add(teamNotSet);

            Visibility = Visibility.Collapsed;
        }

        ///Command
        ///
        public void ChooseTeam(string teamId)
        {
            if (_iCtrl == null)
                return;
            var team = Teams.FirstOrDefault(x => x.Id == teamId);
            _iCtrl.ChooseTeam(team.Id, team.TeamName);
        }
    }
}
