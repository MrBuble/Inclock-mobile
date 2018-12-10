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
            ZXReader.IsAnalyzing =
           // ZXReader.IsScanning =
            GrdLeitor.IsVisible = false;
        }
        public void ReactiveReader()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                GrdLeitor.IsVisible = true;
                ZXReader.IsAnalyzing = true;
                ZXReader.IsScanning = true;
                StlLoader.IsVisible = false;
            });
        }

        public void CreateLoading(string mensager)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Plugin.Vibrate.CrossVibrate.Current.Vibration();
                DesactiveReader();
                LblMensager.Text = mensager;
                StlLoader.IsVisible = true;
            });
        }
        public void FinishLoad(string msg, bool status)
        {
            Plugin.Vibrate.CrossVibrate.Current.Vibration();
            if (status)
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    LblMensager.Text = msg;
                    Thread.Sleep(5000);
                    App.Current.MainPage = new master.Menu();
                });
            }
            else
                FailLoading(msg);
        }
        public void FailLoading(string msg)
        {
            BtnTentarNovamente.Clicked += (obj, ev) => { ReactiveReader(); };
            Device.BeginInvokeOnMainThread(() =>
            {
                LblMensager.Text = msg;
                ImageLoad.IsVisible = false;
                BtnTentarNovamente.IsVisible = true;
            });
        }
    }
}
