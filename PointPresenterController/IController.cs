using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointPresenterController
{
    public interface IController
    {
        void GetTeamsToChoose();
        void ChooseTeam(string teamId, string teamName);
        void GetLauncher();
        void GetScreenShot();
        void ChooseScreen(int id);
        //void LoadHistory();
    }
}
