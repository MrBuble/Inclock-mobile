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
    public partial class Saida : ContentPage
    {
        public Saida()
        {
            var form = new BaseQr.BaseLeituraQr();
            InitializeComponent();
            Content = form.StlLeitor;
            form.ZXReader.OnScanResult += ZXReader_OnScanResult;
        }

        private void ZXReader_OnScanResult(ZXing.Result result)
        {
            DependencyService.Get<IToast>().ShortAlert(result.Text);
        }
    }
}