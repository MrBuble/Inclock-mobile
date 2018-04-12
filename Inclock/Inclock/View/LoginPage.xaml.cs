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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            btnLogar.Clicked += async (sender, e) =>
            {
                if (await DisplayAlert("Login", "O login não esta funcionando, deseja continuar?", "Sim", "Não"))
                {
                    App.Current.MainPage = new MasterPage.Menu();
                }

            };
            btnEsqueciSenha.Clicked += async (sender, e) =>
            {
                if (await DisplayAlert("Esqueci a senha", "Deseja Envia sua senha por email", "Sim", "Não"))
                {

                }

            };
        }


    }
}