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
    public partial class LostAccount : ContentView
    {
        public LostAccount()
        {
            InitializeComponent();
            btnEnviar.Clicked += BtnEnviar_Clicked;
        }

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            if (ValidarEmail())
            {
                using (var client = new Client())
                {
                    client.EnviarSenhaEmail(txtEmail.Text);
                }
            }
            else
            {
                DependencyService.Get<IToast>().LongAlert("Por favor informe um email valido");
            }
        }

        private bool ValidarEmail()
        {
            string expressao = @"/^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$/i";
            Regex reg = new Regex(expressao);
            return reg.IsMatch(txtEmail.Text);
        }
    }
}