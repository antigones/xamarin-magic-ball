using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MagicBall
{
    public partial class MainPage : ContentPage
    {
        readonly Prediction prediction = new Prediction();
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            String p = prediction.MakePrediction();
            predictionLabel.Text = p;
        }
    }
   
}
