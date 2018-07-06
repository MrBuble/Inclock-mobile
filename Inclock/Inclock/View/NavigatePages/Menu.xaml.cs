using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Mobile;
using ZXing.Net.Mobile.Forms;
using Plugin.Vibrate;
using Inclock.BL.Inteface;

namespace Inclock.View.NavigatePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
            btnEntrada.Clicked += BtnEntrada_Clicked;
            btnSaida.Clicked += BtnSaida_Clicked;
        }

        private void BtnSaida_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEntrada_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IToast>().ShortAlert(GetQrCodeAsync());
        }

        public string GetQrCodeAsync()
        {
            MobileBarcodeScanningOptions options = new ZXing.Mobile.MobileBarcodeScanningOptions
            {
                PossibleFormats = new List<ZXing.BarcodeFormat>() { ZXing.BarcodeFormat.QR_CODE, ZXing.BarcodeFormat.MAXICODE },
                AutoRotate = true,
                DisableAutofocus = false,
                TryInverted = true,
                DelayBetweenContinuousScans = 2000
            };
            ZXing.Net.Mobile.Forms.ZXingScannerPage page = new ZXingScannerPage(options)
            {
                DefaultOverlayShowFlashButton = true,
                IsScanning = true,
                BackgroundColor = new Color(222, 222, 222, 1)
            };
            string str = string.Empty;
            page.OnScanResult += (result) =>
                  {
                      page.IsScanning = false;
                      Device.BeginInvokeOnMainThread(() =>
                      {
                          Navigation.PopModalAsync();
                          CrossVibrate.Current.Vibration(TimeSpan.FromSeconds(.1));
                      });
                  };

            Navigation.PushModalAsync(page);
            return str;

            //   var codigo = await reader)
            //   return "";

        }



    }
}