using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointInteractor;

namespace HardDrive
{
    internal class HardDriveDataMapper : HistoryGateway
    {
        DataAccess da;
        public HardDriveDataMapper()
        {
            da = new DataAccess();
        }
        public byte[] GetImageToDisplay()
        {
            return da.GetImageToDisplay();
            //throw new NotImplementedException();
        }

        public string GetTeamToDisplayInJson()
        {
            return da.GetTeamToDisplayInJson();
            //throw new NotImplementedException();
        }

        public bool WriteTeamToDisplayInJson(string json)
        {
            return da.WriteTeamToDisplayInJson(json);
            //throw new NotImplementedException();
        }
    }
}
