using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointInteractor;

namespace HardDrive
{
    public class HardDriveMain
    {
        private HardDriveDataMapper dm;
        public HardDriveMain()
        {
            dm = new HardDriveDataMapper();
        }
        public HistoryGateway GetHistoryGateway()
        {
            return dm as HistoryGateway;
        }
    }
}
