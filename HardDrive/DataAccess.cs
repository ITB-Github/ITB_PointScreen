using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardDrive
{
    internal class DataAccess
    {
        private string _hisFileName = "history.json";
        private string _picFileName = "landing.jpg";
        internal bool WriteTeamToDisplayInJson(string jsonHis)
        {
            using (StreamWriter stream = new StreamWriter(_hisFileName))
            {
                stream.Write(jsonHis);
            }
            return true;
        }
	    internal string GetTeamToDisplayInJson()
        {
            if (!(File.Exists(_hisFileName)))
                return null;

            string json;
            using (StreamReader stream = new StreamReader(_hisFileName))
            {
                json = stream.ReadToEnd();
            }
            return json;
        }
	    internal byte[] GetImageToDisplay()
        {
            if (!(File.Exists(_picFileName)))
                return null;
            return File.ReadAllBytes(_picFileName);

        }
    }
}
