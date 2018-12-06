using Inclock.BL.Inteface;
using Inclock.BL.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View.NavigatePages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LostAccount : ContentPage
    {
        public LostAccount()
        {
            InitializeComponent();
            btnEnviar.Clicked += BtnEnviar_Clicked;
            btnVoltar.Clicked += BtnVoltar_Clicked;
        }

        private void BtnVoltar_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync(true);
        }

        private async void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            if (ValidarEmail())
            {
                using (var client = new Client())
                {
                   await client.EnviarSenhaEmail(txtEmail.Text);
                }
            }
            else
            {
                DependencyService.Get<IToast>().LongAlert("Por favor informe um email valido");
            }
        }

        private bool ValidarEmail()
        {
            string expressao = @"/^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/";
            Regex reg = new Regex(expressao);
            return reg.IsMatch(txtEmail.Text);
        }
    }
}