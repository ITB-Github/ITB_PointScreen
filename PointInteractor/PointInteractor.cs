using PointInteractor.InputData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointEntities;
using Newtonsoft;
using Newtonsoft.Json;
using PointInteractor.OutputData;
using BufferPointEntites;
using Utils;
using System.Windows.Documents;
using Newtonsoft.Json.Linq;

namespace PointInteractor
{
    internal class PointInteractor : InputBoundary
    {
        /// <summary>
        /// Varialble
        /// </summary>
        /// <param></param>
        /// 

        HistoryGateway _IHistory;
        PointDataGateway _IPointDataGateway;
        OutputBoundary _Ioutput;
        ScreenBoundary _IScreen;

        /// <summary>
        /// Composite
        /// </summary>
        /// <param name="id"></param>

        List<Team> _teams;
        Team _teamChosen;

        
        ///
        /// Properties cho code thêm trong sáng
        ///

        Team TeamChosen
        {
            get
            {
                return _teamChosen;
            }
            set
            {
                _teamChosen = value;
                
                _IHistory.WriteTeamToDisplayInJson(JsonConvert.SerializeObject(_teamChosen));
                _teamChosen = JsonConvert.DeserializeObject<Team>(_IPointDataGateway.GetTheTeamInJson(_teamChosen.Id));
                sendTheTeamOutData(produceTheTeamOutData(_teamChosen));     
            }
        }

        List<Team> Teams
        {
            get
            {
                return _teams;
            }
            set
            {
                _teams = value;

                sendTeamListOut(productListTeamOutData(_teams));
            }
        }

        byte[] ImageInByte
        {
            set
            {
                sendLauncher(produceLaucher(value));
            }
        }

        List<Screen> Screens
        {
            set
            {
                sendScreenListOut(produceScreenListOut(value));
            }
        }

        ScreenInstruction ScreenInstruction
        {
            set
            {
                sendScreenInstrOut(produceOutInstruction(value));
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param></param>
        /// 

        //viết trước khi có history
        public PointInteractor(
                               PointDataGateway iPointDataGateway,
                               OutputBoundary iOutput,
                               ScreenBoundary iScreen)
        {            
            _IPointDataGateway = iPointDataGateway;
            _Ioutput = iOutput;
            _IScreen = iScreen;
        }

        // khi có thêm history
        public PointInteractor(HistoryGateway iHistory,
                               PointDataGateway iPointDataGateway,
                               OutputBoundary iOutput,
                               ScreenBoundary iScreen)
        {
            _IHistory = iHistory;
            _IPointDataGateway = iPointDataGateway;
            _Ioutput = iOutput;
            _IScreen = iScreen;
        }

        /// <summary>
        /// Implement Interface
        /// </summary>
        /// <param></param>
        ///
        public void ChooseScreenToMakeFullScreen(int id)
        {

            ScreenInstruction = JsonConvert.DeserializeObject<ScreenInstruction>(_IScreen.GetFullScreenInstruction(id));
            //throw new NotImplementedException();
        }

        public void ReceiveRequestTeams()
        {
            //throw new NotImplementedException();
            Teams = loadTeamsFromGateway();
        }

        public void ReceiveTheTeam(TeamInData data)
        {
            TeamChosen = produceTeamChosen(data);
            //throw new NotImplementedException();
        }

        public void RequestLauncher()
        {
            LoadImageInHistory();
            //throw new NotImplementedException();
        }

        public void RequestScreenShot()
        {
            //throw new NotImplementedException();
            List<Screen> screens = produceListScreenFromJson(_IScreen.GetScreenInfo());
            if (screens != null)
                Screens = screens;
        }

        /// Function Private 
       
        // Produce The Team
        TeamOutData produceTheTeamOutData(Team team)
        {
            return new TeamOutData() {
                Id = team.Id,
                TeamName = team.TeamName,
                Point = team.Point
            };
        }

        void sendTheTeamOutData(TeamOutData team)
        {
            _Ioutput.ReceiveTheTeam(team);
        }

        // Produce List Of Team
        List<TeamOutData> productListTeamOutData(List<Team> teams)
        {
            List<TeamOutData> list = new List<TeamOutData>();
            foreach(var team in teams)
            {
                list.Add(
                    new TeamOutData()
                    {
                        Id = team.Id,
                        TeamName = team.TeamName,
                        Point = team.Point
                    }
                );

            }

            return list;

        }

        void sendTeamListOut(List<TeamOutData> list)
        {
            _Ioutput.ReceiveTeams(list);
        }

        // produce Launcher Data
        LauncherOutData produceLaucher(byte[] imgInByte)
        {
            return new LauncherOutData() { Launcher = imgInByte };
        }
        void sendLauncher(LauncherOutData launcher)
        {
            _Ioutput.ReceiveLauncher(launcher);
        }


        // load Teams From Gateway

        List<Team> loadTeamsFromGateway()
        {
            return JsonConvert.DeserializeObject<List<Team>>(_IPointDataGateway.GetTeamsInJson());
        }

        // produce teamChosen from Team InputData

        Team produceTeamChosen(TeamInData teamIn)
        {
            return new Team()
            {
                Id = teamIn.Id,
                TeamName = teamIn.TeamName,
                Point = teamIn.Point
            };
        }


        // produce List<Screen> Out Put

        List<ScreenOutData> produceScreenListOut(List<Screen> screens)
        {
            List<ScreenOutData> list = new List<ScreenOutData>();
            foreach(var screen in screens){
                list.Add(
                    new ScreenOutData()
                    {
                        Id = screen.Id,
                        ScreenShot = Converter.FromBase64ToBytes(screen.ScreenShot)
                    }
                );
            }
            return list;
        }

        void sendScreenListOut(List<ScreenOutData> list)
        {
            _Ioutput.RecieveScreens(list);
        }

        // produce Screen Instruction Out
        ScreenOutInstruction produceOutInstruction(ScreenInstruction instruction)
        {
            return new ScreenOutInstruction()
            {
                Top = instruction.Top,
                Left = instruction.Left,
                IsMaximized = instruction.IsMaximized,
                IsShown = instruction.IsShown
            };
        }

        void sendScreenInstrOut(ScreenOutInstruction instruction)
        {
            _Ioutput.RecieveFullScreenInstruction(instruction);
        }


        //Produce List Screen From Json
        List<Screen> produceListScreenFromJson(string json)
        {

            List<Screen> list = new List<Screen>();

            try
            {
                JArray arr = JArray.Parse(json);
                foreach(var child in arr.Children())
                {
                    list.Add(new Screen()
                    {
                        Id = child.SelectToken("Id").ToObject<int>(),
                        ScreenShot = child.SelectToken("ScreenShot").ToObject<string>()
                    }) ;
                    
                }
            }
            finally
            {
                
            }
            return list;

        }

        /// Function cho History
        /// 
        void LoadHistory()
        {
            

        }

        void LoadTeamInHistory()
        {
            string teamJson = _IHistory.GetTeamToDisplayInJson();
            Team team = JsonConvert.DeserializeObject<Team>(teamJson);
            if(team.Id != null)
            {
                TeamChosen = team;
            }    
                

        }

        void LoadImageInHistory()
        {
            var img = _IHistory.GetImageToDisplay();
            if(img!=null)
            {
                ImageInByte = img;
            }
        }

    }
}
