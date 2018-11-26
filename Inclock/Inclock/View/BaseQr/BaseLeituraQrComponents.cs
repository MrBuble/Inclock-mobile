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
            
            LblMensager = new Label
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Start,
                Text = "kiko"
            };
            ImageLoad = new FFImageLoading.Svg.Forms.SvgCachedImage
            {
                Source = "loading.gif",
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.Start,
                Scale = 3
            };
            BtnTentarNovamente = new Button
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start,
                BackgroundColor = Color.Transparent,
                IsVisible = false,
                Text = "Tentar Novamente"
            };
            StlLoader = new StackLayout
            {
                IsVisible = false,
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    LblMensager,
                    new AbsoluteLayout
                    {
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        HorizontalOptions = LayoutOptions.CenterAndExpand,
                        Children = { ImageLoad }
                    },
                    BtnTentarNovamente
                }
            };

            StlLeitor = new StackLayout()
            {
                BackgroundColor = Color.Transparent,
                Children = { GrdLeitor,StlLoader }
            };
        }

    }
}
