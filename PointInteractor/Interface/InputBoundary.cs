using PointInteractor.InputData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInteractor
{
    public interface InputBoundary
    {
        void ReceiveTheTeam(TeamInData data);
        void ReceiveRequestTeams();
        void RequestLauncher();
        void RequestScreenShot();
        void ChooseScreenToMakeFullScreen(int id);
    }
}
