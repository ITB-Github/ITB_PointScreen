using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointInteractor;

namespace SQLserverConnect
{
    internal class DataMapper : PointDataGateway
    {
        DataAccess sqlserver;
        public DataMapper()
        {
            if(sqlserver == null)
            {
                sqlserver = new DataAccess();
            }    
        }
        public string GetTeamsInJson()
        {
            return sqlserver.GetTeamsInJson();
        }

        public string GetTheTeamInJson(string teamId)
        {
            return sqlserver.GetTheTeamInJson(teamId);
            //throw new NotImplementedException();
        }
    }
}
