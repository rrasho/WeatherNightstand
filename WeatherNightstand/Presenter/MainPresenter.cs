using WeatherNightstand.View;
using WeatherNightstand.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNightstand.Presenter
{
    class MainPresenter
    {
        IMainView _view;
        IMainModel _model;

        public MainPresenter(IMainView v, IMainModel m)
        {
            _view = v;
            _model = m;
            _view.selectLocation += new EventHandler(_view_selectLocation);
        }

        private void _view_selectLocation(object sender, EventArgs e)
        {
            Console.WriteLine($"{_model.GetCurrentConditions("")}");
        }

    }
}
