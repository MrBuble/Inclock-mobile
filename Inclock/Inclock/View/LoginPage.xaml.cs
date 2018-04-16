using Inclock.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
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
                try
                {
                    imgLogin.IsVisible = true;
                    FeedBack feed = await BL.Login.Logar(txtlogin.Text, txtSenha.Text);
                    if (!feed.Status)
                        await DisplayAlert("Login", feed.Mensagem, "OK");
                    else
                        App.Current.MainPage = new MasterPage.Menu();
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Login", ex.Message, "OK");
                }
                finally
                {
                    imgLogin.IsVisible = false;
                }
            };
            btnEsqueciSenha.Clicked += async (sender, e) =>
            {
                if (await DisplayAlert("Esqueci a senha", "Deseja Envia sua senha por email", "Sim", "Não"))
                {
                    if (string.IsNullOrEmpty(txtlogin.Text))
                    {
                        DependencyService.Get<BL.Inteface.IToast>().ShortAlert("Informe seu login primeiro");
                        Animation am = new Animation();
                        txtlogin.Focus();
                    }
                    DependencyService.Get<BL.Inteface.IToast>().ShortAlert("Sua senha foi enviada para o seu email");
                }

            };
        }

        public void ValidaCampos()
        { }
    }
}