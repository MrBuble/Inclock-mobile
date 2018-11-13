using Inclock.BL.Inteface;
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
    public partial class Saida : ContentPage
    {
        public BaseLeituraQr BaseQr = new BaseLeituraQr();
        public Saida()
        {
            InitializeComponent();
            Content = BaseQr.StlLeitor;
            BaseQr.ZXReader.OnScanResult += ZXReader_OnScanResult;            
        }
        
        private async void ZXReader_OnScanResult(ZXing.Result result)
        {
            
            BaseQr.CreateLoading("Aguarde...");           
            using (var client = new Client())
            {
                BL.Login.GetCurrentUser();
               
                var retorno = await client.CheckPoint(BL.Login.GetFuncionario(), 'S');
                if (retorno.Status)
                {
                    Plugin.Vibrate.CrossVibrate.Current.Vibration();
                    BaseQr.LblMensager.Text = retorno.Mensagem;
                    Thread.Sleep(5000);
                    App.Current.MainPage = new master.Menu();
                }
                else
                {   BaseQr.ReactiveReader();
                    Plugin.Vibrate.CrossVibrate.Current.Vibration();
                    BaseQr.ZXOverlay.BottomText = retorno.Mensagem;
                }
               
            }

        }
    }
}