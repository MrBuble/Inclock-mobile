using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View.BaseQr
{

    public partial class BaseLeituraQr
    {
        public ViewModels.GetQrViewModel ViewModel = new Inclock.ViewModels.GetQrViewModel();
        public BaseLeituraQr()
        {
            InitializeComponent();
            ZXReader.BindingContext = ViewModel;
            ZXReader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE);
        }
        public void DesactiveReader()
        {
            ZXReader.IsScanning = false;
            GrdLeitor.IsEnabled = false;

            GrdLeitor.Opacity = 0;

        }
        public void ReactiveReader()
        {
            StlLoader.Opacity = 0;
            GrdLeitor.IsEnabled = true;
            ZXReader.IsScanning = true;
            GrdLeitor.Opacity = 1;

        }

        public void CreateLoading(string mensager)
        {

            Plugin.Vibrate.CrossVibrate.Current.Vibration();
            DesactiveReader();
            LblMensager.Text = mensager;
            StlLoader.Opacity = 1;

        }
        public void FinishLoad(string msg, bool status)
        {

            Plugin.Vibrate.CrossVibrate.Current.Vibration();
            if (status)
            {
                LblMensager.Text = msg;
                Thread.Sleep(5000);
                App.Current.MainPage = new master.Menu();
            }
            else
                FailLoading(msg);
        }
        public void FailLoading(string msg)
        {
            BtnTentarNovamente.Opacity = StlLoader.Opacity = 1;
            LblMensager.Text = msg;
            ImageLoad.IsVisible = false;
            BtnTentarNovamente.Clicked += (obj, ev) => { ReactiveReader(); };
        }
    }
}
