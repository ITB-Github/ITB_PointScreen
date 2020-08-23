using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using FullScreenImplement;
using Newtonsoft.Json.Linq;
using Utils;

namespace PointTestWPF
{
    internal class FullScreenImplementationTestCase
    {
        ScreenImplementation _fsc;
        public FullScreenImplementationTestCase()
        {
            _fsc = new ScreenImplementation();
        }
        public ImageSource PrimaryScreenTest()
        {
            
            string info = _fsc.GetScreenInfo();
            JArray json = JArray.Parse(info);

            string base64Image = json.First.SelectToken("ScreenShot").ToObject<string>();
            return GUIconverter.ByteToImage(Converter.FromBase64ToBytes(base64Image));

            
        }

        public string GetScreenInstructionTest()
        {
            string instruction = _fsc.GetFullScreenInstruction(0);
            return instruction;
        }

        public void DoScreenInstructionTest()
        {
            string instruction = _fsc.GetFullScreenInstruction(0);
            
            JObject json = JObject.Parse(instruction);
            int xValue = (int)json["Left"];
            int yValue = (int)json["Top"];
            bool isMaximized = (bool)json["IsMaximized"];
            bool isShown = (bool)json["IsShown"];
            
            Window testGui = new Window();
            testGui.Width = 600;
            testGui.Height = 400;

            testGui.Left = xValue;
            testGui.Top = yValue;
            if (isShown)
            {
                testGui.Show();
            }
            if (isMaximized)
            {
                testGui.WindowState = WindowState.Maximized;
            }


        }
    }
}
