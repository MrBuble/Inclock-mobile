using Inclock.BL.Rest;
using Inclock.View.BaseQr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View.NavigatePages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Entrada : ContentPage
	{
        public BaseLeituraQr BaseQr = new BaseLeituraQr();
		public Entrada ()
		{
			InitializeComponent ();
            Content = BaseQr.StlLeitor;
            BaseQr.ZXReader.OnScanResult +=  ZXReader_OnScanResultAsync;
		}

        private async void ZXReader_OnScanResultAsync(ZXing.Result result)
        {
            BaseQr.DesactiveReader();
            Plugin.Vibrate.CrossVibrate.Current.Vibration();
            BaseQr.ZXOverlay.BottomText = "Aguarde...";
            using (var client = new Client())
            {
                BL.Login.GetCurrentUser();
                var retorno = await client.CheckPoint(BL.Login.GetFuncionario(), 'E');
                if (retorno.Status)
                {
                    Plugin.Vibrate.CrossVibrate.Current.Vibration();
                    BaseQr.ZXOverlay.BottomText = retorno.Mensagem;
                    Thread.Sleep(5000);
                    App.Current.MainPage = new master.Menu();
                }
                else
                {
                    BaseQr.ReactiveReader();
                    Plugin.Vibrate.CrossVibrate.Current.Vibration();
                    BaseQr.ZXOverlay.BottomText = retorno.Mensagem;
                }
            }
        }
    }
}