using PointInteractor.OutputData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInteractor
{
    public interface OutputBoundary
    {
        void ReceiveTheTeam(TeamOutData data);
        void ReceiveTeams(List<TeamOutData> datas);
        void ReceiveLauncher(LauncherOutData img);
        void RecieveScreens(List<ScreenOutData> scr);
        void RecieveFullScreenInstruction(ScreenOutInstruction instruction);
    }
}
