using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using InTheHand.Forms;

namespace InTheHandSetPosition
{
    public partial class MainPage : ContentPage
    {
        public MediaElement mediaView = new MediaElement();
        public MainPage()
        {
            //InitializeComponent();
            var stack = new StackLayout();
            
            mediaView.HeightRequest = 70.0;
            mediaView.WidthRequest = 70.0;
            //mediaView.Source = new Uri("https://raw.githubusercontent.com/mediaelement/mediaelement-files/master/big_buck_bunny.mp4");
            //mediaView.AreTransportControlsEnabled = true;
            var button = new Button();
            button.Text = "Set Position";
            button.Clicked += Button_Clicked;
            var loadButton = new Button();
            loadButton.Text = "Load Video";
            loadButton.Clicked += LoadButton_Clicked;
            
            stack.Children.Add(mediaView);
            stack.Children.Add(button);
            stack.Children.Add(loadButton);

            Content = stack;
        }

        private void LoadButton_Clicked(object sender, EventArgs e)
        {
            mediaView.Source = new Uri("https://raw.githubusercontent.com/mediaelement/mediaelement-files/master/big_buck_bunny.mp4");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var randomNumberGenerator = new System.Random();
            var rand = randomNumberGenerator.NextDouble();
            mediaView.Position = TimeSpan.FromSeconds(10.0+rand); // only works on android and windows not iOS
            //mediaView.Position = TimeSpan.FromSeconds(10.0); //doesn't work on any platform
        }
    }
}
