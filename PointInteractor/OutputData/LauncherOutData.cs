using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInteractor.OutputData
{
    public struct LauncherOutData
    {
        [JsonProperty("Launcher")]
        public byte[] Launcher { get; set; }
    }
}
