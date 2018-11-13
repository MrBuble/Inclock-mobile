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
        public StackLayout StlLoader { get; set; }
        public FFImageLoading.Svg.Forms.SvgCachedImage ImageLoad { get; set; }
        public Label LblMensager { get; set; }
        public Button BtnTentarNovamente { get; set; }
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
            GrdLeitor = new Grid
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
            LblMensager = new Label
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = ""
            };
            ImageLoad = new FFImageLoading.Svg.Forms.SvgCachedImage
            {
                Source = ImageSource.FromFile("loading.gif"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            StlLoader = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Start,
                Children =
                {
                    LblMensager,
                    new AbsoluteLayout
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Children = {ImageLoad }
                    }
                }
            };
            BtnTentarNovamente = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.Transparent,
                Text = "Tentar Novamente"
            };
        }

    }
}
