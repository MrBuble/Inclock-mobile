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
        public Ponto()
        {
            InitializeComponent();
            lblQrCode.BindingContext = new Inclock.ViewModels.GetQrViewModel();
            btnBateEntrada.Clicked += BtnBateEntrada_Clicked;
        }

        private void BtnBateEntrada_Clicked(object sender, EventArgs e)
        {
            ViewModels.GetQrViewModel qr = new ViewModels.GetQrViewModel();
            qr.Get();
        }
    }
}