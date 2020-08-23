using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace PointInteractor
{
    public interface ScreenBoundary
    {
        string GetNormalScreenInstruction();
        string GetFullScreenInstruction(int screenId);
        string GetScreenInfo();
    }
}
