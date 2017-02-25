using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNightstand.Model
{
    interface IMainModel
    {
        // some sort of current conditions struct. for now use just a double for temp...
        double GetCurrentConditions(string location);

    }
}
