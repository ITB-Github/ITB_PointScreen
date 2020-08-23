using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PointPresenterController
{
    public class ScreenViewModel
    {
        public int Id { get; set; }
        public ImageSource Image { get; set; }
        public ScreenViewModel()
        {
            Id = -1;
            Image = Converter.ByteToImage(Utils.Converter.FromBase64ToBytes(Resources.NoImageBase64));
        }

        public ScreenViewModel(int id, ImageSource img)
        {
            Id = id;
            Image = img;
        }

    }
}
