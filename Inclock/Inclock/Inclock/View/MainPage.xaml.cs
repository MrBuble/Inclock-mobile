using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            var label = new Label { };
            //  btnEsqueciSenha.Clicked += BtnEsqueciSenha_Clicked;
            InitializeComponent();
        }

        private async void BtnEsqueciSenha_Clicked(object sender, EventArgs e)
        {
           
            string str = "";
            try
            {
             //   str = Inclock.library.Autenticar.Logar();
            }
            catch (Exception ex)
            {
                str = ex.Message;
                throw;
            }
            //  await DisplayAlert("Senha", "Sua Senha foi Encaminhada para o seu email", "OK");
            await DisplayAlert("Senha", str, "OK");
        }
    }
}