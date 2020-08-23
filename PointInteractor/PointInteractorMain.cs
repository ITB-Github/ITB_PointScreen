using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInteractor
{
    public class PointInteractorMain
    {
        private PointInteractor interactor;
        public PointInteractorMain(HistoryGateway iHistory, ScreenBoundary iScreen, PointDataGateway iPointData, OutputBoundary iOut)
        {
            interactor = new PointInteractor(
                                                 iHistory,
                                                 iPointData,
                                                 iOut,
                                                 iScreen
                                              );
        }

        public InputBoundary GetInputBoundary()
        {
            return interactor as InputBoundary;
        }
    }
}
