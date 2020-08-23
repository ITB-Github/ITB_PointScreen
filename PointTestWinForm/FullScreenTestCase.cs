using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FullScreenImplement;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Utils;

namespace PointTestWinForm
{
    internal class FullScreenTestCase
    {
        ScreenImplementation _fsc;
        public FullScreenTestCase()
        {
            _fsc = new ScreenImplementation();
        }
        public Bitmap PrimaryScreenTest()
        {
            Bitmap bitmap = null;
            string info = _fsc.GetScreenInfo();
            JArray json = JArray.Parse(info);

            string base64Image = json.First.SelectToken("ScreenShot").ToObject<string>();
            bitmap = Converter.FromBytesToBitmap(Converter.FromBase64ToBytes(base64Image));

            return bitmap;
        }
    }
}
