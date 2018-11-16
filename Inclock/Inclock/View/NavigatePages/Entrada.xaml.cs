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
            InitializeComponent();
            Content = BaseQr.StlLeitor;
            BaseQr.ZXReader.OnScanResult +=  ZXReader_OnScanResultAsync;
		}

        private async void ZXReader_OnScanResultAsync(ZXing.Result result)
        {
            BaseQr.CreateLoading("Aguarde...");
            using (var client = new Client())
            {
                var retorno = await client.CheckPoint(BL.Login.GetFuncionario(), 'E');
                BaseQr.FinishLoad(retorno.Mensagem, false);
            }
        }
    }
}