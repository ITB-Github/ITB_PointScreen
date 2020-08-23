using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using SQLserverConnect;
using PointInteractor;
using PointViewWPF;
using FullScreenImplement;
using PointPresenterController;
using HardDrive;


namespace PointRunner
{
    public static class PointRunnerMain
    {
        [STAThread]
        public static void Main()
        {
            //HardDriveMain hdMain = new HardDriveMain();
            //ScreenImplementationMain screenMain = new ScreenImplementationMain();
            //SQLserverConnectMain sqlMain = new SQLserverConnectMain();

            //PointViewMain viewMain = new PointViewMain();
            
            //PointPresenterControllerMain pcMain = new PointPresenterControllerMain(
            //    viewMain.GetPointViewModel(),
            //    viewMain.GetTeamChosenViewModel(),
            //    viewMain.GetPreviewViewModel());

            //PointInteractorMain interactorMain = new PointInteractorMain(
            //    hdMain.GetHistoryGateway(),
            //    screenMain.GetScreenBoundary(),
            //    sqlMain.GetPointDataGateway(),
            //    pcMain.GetOutputBoundary()
            //    );

            Application app = new Application();
            //Window gui = viewMain.GetMainWindow();
            app.Run(new MainWindow());



        }
    }
}
