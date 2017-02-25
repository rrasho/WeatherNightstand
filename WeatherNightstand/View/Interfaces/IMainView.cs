using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNightstand.View
{
    interface IMainView
    {
        event EventHandler selectLocation;
        event EventHandler FormClosed;
        void Show();
        void Close();
    }
}
