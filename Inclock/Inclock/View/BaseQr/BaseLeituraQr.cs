using System;
using System.Collections.Generic;
using System.Text;
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
            InitializeComponent();
            //      ViewModel.IsScanning = true;
            //     GrdLeitor.IsVisible = true;
            //    StlLeitor.Children.Remove(StlLoader);
        }

        public void CreateLoading(string mensager)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                Plugin.Vibrate.CrossVibrate.Current.Vibration();
                DesactiveReader();            
                LblMensager.Text = mensager;
                StlLeitor.Children.Add(StlLoader);
            });
            
        }
        public void FinishLoad(string mensager)
        {
            Plugin.Vibrate.CrossVibrate.Current.Vibration();
            ImageLoad.IsVisible = false;
            DesactiveReader();
        }
        public void FailLoading(string mensager)
        {
            LblMensager.Text = mensager;
            ImageLoad.IsVisible = false;
            BtnTentarNovamente.Clicked += (obj, ev) => { ReactiveReader(); };
            StlLoader.Children.Add(BtnTentarNovamente);
        }
    }
}
