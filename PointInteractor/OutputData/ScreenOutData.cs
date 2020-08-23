﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInteractor.OutputData
{
    public struct ScreenOutData
    {
        [JsonProperty("Id")]
        public int Id { get; set; }
        [JsonProperty("ScreenShot")]
        public byte[] ScreenShot { get; set; }
    }
}
