using WeatherNightstand.Model;
using WeatherNightstand.Presenter;
using WeatherNightstand.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherNightstand
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mainModel = new MainModel();
            MainView mainView = new MainView();
            new MainPresenter(mainView, mainModel);
            Application.Run(mainView);
        }
    }
}
