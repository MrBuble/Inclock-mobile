using Inclock.BL.Inteface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View.NavigatePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ponto : ContentPage
    {
        public ViewModels.GetQrViewModel ViewModel = new Inclock.ViewModels.GetQrViewModel();
        public Ponto()
        {

            InitializeComponent();

            //lblQrCode.BindingContext = ViewModel;
              zxReader.BindingContext = new ViewModels.GetQrViewModel();
            zxReader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE); 
                       
        }        

        private void BtnBateEntrada_Clicked(object sender, EventArgs e)
        {
            ZXing.Mobile.MobileBarcodeScanner reader = new ZXing.Mobile.MobileBarcodeScanner();

            ZXing.Mobile.MobileBarcodeScanningOptions options = new ZXing.Mobile.MobileBarcodeScanningOptions
            {
                PossibleFormats = new List<ZXing.BarcodeFormat> { ZXing.BarcodeFormat.QR_CODE, ZXing.BarcodeFormat.RSS_14 }
            };
            reader.BottomText = "Scanner";
            reader.CancelButtonText = "Cancelar";
            reader.CameraUnsupportedMessage = "Camera não é suportada";
            reader.AutoFocus();
            reader.FlashButtonText = "Flash";


            ZXing.Mobile.MobileBarcodeScanner ss = new ZXing.Mobile.MobileBarcodeScanner();

                 var codigo = reader.Scan(options);           
                  ViewModel.StQrCode = codigo.Result.ToString();

        }
    }
}