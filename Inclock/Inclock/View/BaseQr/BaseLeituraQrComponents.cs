using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;
using System.Collections.ObjectModel;
namespace Inclock.View.BaseQr
{
    public partial class BaseLeituraQr
    {

        public StackLayout StlLeitor { get; set; }
        public Grid GrdLeitor { get; set; }
        public ZXingScannerView ZXReader { get; set; }
        public ZXingDefaultOverlay ZXOverlay { get; set; }
        private void InitializeComponent()
        {
            ZXReader = new ZXingScannerView
            {
                AutomationId = "ZXingScannerView",
                InputTransparent = true,
                IsAnalyzing = ViewModel.IsAnalyzing,
                IsScanning = ViewModel.IsScanning,
                IsTorchOn = true
            };
            ZXOverlay = new ZXingDefaultOverlay
            {
                AutomationId = "ZXingDefaultOverlay",
                BackgroundColor = Color.Transparent,
                BottomText = "Aponte para o Qr Code",
                TopText = "Registrar ponto"
            };
            GrdLeitor = new Grid()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { ZXReader, ZXOverlay }
            };
            StlLeitor = new StackLayout()
            {
                BackgroundColor = Color.Transparent,
                Children = { GrdLeitor }
            };
        }

    }
}
