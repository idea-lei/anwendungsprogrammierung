using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dashcam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashcamPage : ContentPage
    {
        public DashcamPage()
        {
            InitializeComponent();
            initColor = btn_ToggleRecording.BackgroundColor;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (!cts.IsCancellationRequested) cts.Cancel();
            if (cts != null) cts.Dispose();
        }

        private Color initColor;
        private CancellationTokenSource cts;
        private async void btn_ToggleRecording_Clicked(object sender, EventArgs e)
        {
            if (btn_ToggleRecording.Text == "Record")
            {
                btn_ToggleRecording.Text = "Stop";
                btn_ToggleRecording.BackgroundColor = Color.Red;

                // get gps
                cts = new CancellationTokenSource();
                await Task.Run(GetSpeed, cts.Token);
            }
            else
            {
                btn_ToggleRecording.Text = "Record";
                btn_ToggleRecording.BackgroundColor = initColor;
                lbl_Speed.Text = $"Current Speed";
                cts.Cancel();
            }

            cameraView.Shutter();
        }

        private async Task GetSpeed()
        {
            while (true)
            {
                await Task.Delay(1000);
                if (cts == null) return;
                if (cts.IsCancellationRequested)
                {
                    cts.Dispose();
                    return;
                }
                try
                {
                    var location = await Geolocation.GetLocationAsync();

                    if (location != null)
                    {
                        Dispatcher.BeginInvokeOnMainThread(() =>
                        {
                            lbl_Speed.Text = $"Current Speed: {location.Speed * 3.6} Km/h";
                        });
                    }
                }
                catch (FeatureNotSupportedException fnsEx) { }
                catch (FeatureNotEnabledException fnwEx) { }
                catch (PermissionException pEx) { }
                catch (Exception ex) { }
            }
        }
    }
}