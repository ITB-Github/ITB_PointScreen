using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInteractor
{
    public interface PointDataGateway
    {
        string GetTeamsInJson();
        string GetTheTeamInJson(string teamId);
    }
}
