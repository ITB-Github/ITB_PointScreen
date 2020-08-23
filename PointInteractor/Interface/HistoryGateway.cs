using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInteractor
{
    public interface HistoryGateway
    {
        bool WriteTeamToDisplayInJson(string json);
        string GetTeamToDisplayInJson();
        byte[] GetImageToDisplay();
    }
}
