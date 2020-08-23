using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointInteractor;

namespace SQLserverConnect
{
    public class SQLserverConnectMain
    {
        private DataMapper dm;
        public SQLserverConnectMain()
        {
            dm = new DataMapper();
        }
        public PointDataGateway GetPointDataGateway()
        {
            return dm as PointDataGateway;
        }
    }
}
