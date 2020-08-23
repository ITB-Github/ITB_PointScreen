using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointInteractor;
using PointInteractor.InputData;

namespace PointPresenterController
{
    internal class Controller : IController
    {

        /// <summary>
        /// Phần Aggreagation
        /// </summary>

        InputBoundary _iInput;
        public void AttachInput(InputBoundary iInput)
        {
            _iInput = iInput;
        }


        /// <summary>
        /// Phần Interface
        /// </summary>
        /// <param name="id"></param>
        public void ChooseScreen(int id)
        {
            //throw new NotImplementedException();
            sendScreenIdToMakeFullScreeen(id);
        }

        

        public void ChooseTeam(string teamId, string teamName)
        {
            TeamInData team = new TeamInData();
            team.Id = teamId;
            team.TeamName = teamName;
            team.Point = -1;

            requestTheTeam(team);
            //throw new NotImplementedException();
        }

        

        public void GetLauncher()
        {
            sendToGetLaucher();
            //throw new NotImplementedException();
        }

        

        public void GetScreenShot()
        {
            sendToGetScreenShot();
            //throw new NotImplementedException();
        }

        public void GetTeamsToChoose()
        {
            //throw new NotImplementedException();
            sendRequestTeams();
        }



        /// <summary>
        /// Phần gọi InputBoundary
        /// </summary>
        /// <param name="id"></param>
        private void sendScreenIdToMakeFullScreeen(int id)
        {
            if (_iInput == null)
                return;
            _iInput.ChooseScreenToMakeFullScreen(id);
            //throw new NotImplementedException();
        }
        private void requestTheTeam(TeamInData team)
        {
            if (_iInput == null)
                return;
            _iInput.ReceiveTheTeam(team);
            //throw new NotImplementedException();
        }
        private void sendRequestTeams()
        {
            if (_iInput == null)
                return;
            _iInput.ReceiveRequestTeams();
            //throw new NotImplementedException();
        }
        private void sendToGetLaucher()
        {
            if (_iInput == null)
                return;
            _iInput.RequestLauncher();
            //throw new NotImplementedException();
        }

        void sendToGetScreenShot()
        {
            if (_iInput == null)
                return;
            _iInput.RequestScreenShot();
        }
    }
}
