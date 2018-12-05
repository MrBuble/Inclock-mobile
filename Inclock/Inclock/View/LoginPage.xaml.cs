using Inclock.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Inclock.BL.SqlLite;

namespace Inclock.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {  
            InitializeComponent();          
            btnLogar.Clicked += BtnLogar_Clicked;
            btnEsqueciSenha.Clicked += BtnEsqueciSenha_Clicked;
        }
      
        private async void BtnEsqueciSenha_Clicked(object sender, EventArgs e)
        {
            bool dialog = await DisplayAlert("Esqueci a senha", "Deseja Envia sua senha por email", "Sim", "Não");
            if (dialog)
            {
                if (string.IsNullOrEmpty(txtlogin.Text))
                {
                    DependencyService.Get<BL.Inteface.IToast>().ShortAlert("Informe seu Email");
                }
                else
                {
                    DependencyService.Get<BL.Inteface.IToast>().ShortAlert("Sua senha foi enviada no seu email");
                }
            }
        }
        private async void BtnLogar_Clicked(object sender, EventArgs e)
        {
            try
            {
                ValidaCampos();
                imgLogin.IsVisible = true;
                var user = await BL.Login.Logar(txtlogin.Text, txtSenha.Text);
                if (user.Id == 0)
                    await DisplayAlert("Erro", "Login ou senha estão incorretos", "OK");

                else
                {
                    BL.Login.CreateSession(user);
                    Application.Current.MainPage = new master.Menu();
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Login", ex.Message, "OK");
            }
            finally
            {
                imgLogin.IsVisible = false;
            }
        }

        public void ValidaCampos()
        {
            if (string.IsNullOrEmpty(txtlogin.Text) || string.IsNullOrEmpty(txtSenha.Text))
                throw new Exception("Preencha todos os campos ", new Exception("Erro humano"));
        }
    }
}