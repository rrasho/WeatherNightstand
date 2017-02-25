using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNightstand.Model
{
    class MainModel : IMainModel
    {
        public double GetCurrentConditions(string location)
        {
            // hit wunderground library for this
            return 0.0;
        }
    }
}
