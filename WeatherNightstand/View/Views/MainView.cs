using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherNightstand.View
{
    class MainView : Form, IMainView
    {
        private Button selectLocationButton;

        public event EventHandler selectLocation;
        public new event EventHandler FormClosed;
        public MainView()
        {
            InitializeComponent();

            this.selectLocationButton.Click += delegate
            {
                var handler = this.selectLocation;

                if (handler != null)
                {
                    handler(this, EventArgs.Empty);
                }
            };
            
        }

        private void InitializeComponent()
        {
            this.selectLocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectLocationButton
            // 
            this.selectLocationButton.Location = new System.Drawing.Point(13, 13);
            this.selectLocationButton.Name = "selectLocationButton";
            this.selectLocationButton.Size = new System.Drawing.Size(75, 23);
            this.selectLocationButton.TabIndex = 0;
            this.selectLocationButton.Text = "selectLocationButton";
            this.selectLocationButton.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Controls.Add(this.selectLocationButton);
            this.Name = "MainView";
            this.ResumeLayout(false);

        }
    }
}
