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
        {   InitializeComponent();
            ZXReader.BindingContext = ViewModel;
            ZXReader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE);
         
        }
    }
}
