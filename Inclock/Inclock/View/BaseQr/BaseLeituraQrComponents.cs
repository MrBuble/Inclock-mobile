using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using ZXing.Net.Mobile.Forms;

namespace Inclock.View.BaseQr
{
    partial class BaseLeituraQr
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
                IsScanning = ,
                IsTorchOn = true,
                Result = "{Binding Result, Mode=TwoWay}",
                ScanResultCommand = "QRScanResultCommand"

            };ZXReader.Bounds.i
        
            GrdLeitor = new Grid()
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            StlLeitor = new StackLayout()
            {
                BackgroundColor = Color.Transparent,
                Children = { GrdLeitor }
            };
        }
    }
}
