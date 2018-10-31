using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View.BaseQr
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    partial class BaseLeituraQr : ContentPage
    {
        public ViewModels.GetQrViewModel ViewModel = new Inclock.ViewModels.GetQrViewModel();
        public BaseLeituraQr()
        {
            
            ZXReader.BindingContext = new ViewModels.GetQrViewModel();
            ZXReader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE);
        }
    }
}
