using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInteractor.InputData
{
    public struct TeamInData
    {
        [JsonProperty("Id")]
        public string Id { get; set; }
        [JsonProperty("TeamName")]
        public string TeamName { get; set; }
        [JsonProperty("Point")]
        public int Point { get; set; }
    }
}
