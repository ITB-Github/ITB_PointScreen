using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using HardDrive;
using FullScreenImplement;
using PointInteractor;
using PointPresenterController;
using SQLserverConnect;
namespace PointViewWPF
{
    public static class App
    {
        [STAThread]
        public static void Main()
        {
            HardDriveMain hdMain = new HardDriveMain();
            ScreenImplementationMain screenMain = new ScreenImplementationMain();
            SQLserverConnectMain sqlMain = new SQLserverConnectMain();

            PointViewMain viewMain = new PointViewMain();

            PointPresenterControllerMain pcMain = new PointPresenterControllerMain(
                viewMain.GetPointViewModel(),
                viewMain.GetTeamChosenViewModel(),
                viewMain.GetPreviewViewModel());

            PointInteractorMain interactorMain = new PointInteractorMain(
                hdMain.GetHistoryGateway(),
                screenMain.GetScreenBoundary(),
                sqlMain.GetPointDataGateway(),
                pcMain.GetOutputBoundary()
                );

            pcMain.AttachInputBoundary(interactorMain.GetInputBoundary());

            Application app = new Application();
            app.Run(viewMain.GetMainWindow());
        }
    }
}
