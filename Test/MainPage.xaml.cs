using System;
using System.ComponentModel;
using MediaManager;
using MediaManager.Library;
using Xamarin.Forms;

namespace Test
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();


            //this is what I want to achieve. This does not work Android. On iOS it works
            CrossMediaManager.Current.Play(new MediaItem("https://vjs.zencdn.net/v/oceans.mp4"), startAt: TimeSpan.FromMilliseconds(0), stopAt: TimeSpan.FromMilliseconds(2500));

            //this is what does not work either. On iOS it works
            //CrossMediaManager.Current.Play(new MediaItem("https://vjs.zencdn.net/v/oceans.mp4"));
        }
    }
}
