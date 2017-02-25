using WeatherNightstand.Model;
using WeatherNightstand.Presenter;
using WeatherNightstand.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherNightstand
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            //progressBar1
            IMainModel mainModel = new MainModel();
            IMainView mainView = new MainView();
            new MainPresenter(mainView, mainModel);
            Hide();
            mainView.FormClosed += (s, args) => Console.WriteLine("Close Test");
            mainView.Show();
        }
    }
}
