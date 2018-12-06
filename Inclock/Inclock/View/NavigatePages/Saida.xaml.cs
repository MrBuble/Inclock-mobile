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
            using (var client = new Client())
            {
                BaseQr.CreateLoading("Aguarde...");
                var retorno = await client.CheckPoint(BL.Login.GetFuncionario(), 'S',result.Text);
                BaseQr.FinishLoad(retorno.Mensagem, false);

            }
        }
    }
}