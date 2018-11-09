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
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();
            btnSim.Clicked += BtnSim_Clicked;
            btnNao.Clicked += BtnNao_Clicked;
        }

        private void BtnNao_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new Inclock.View.master.Menu();
        }

        private void BtnSim_Clicked(object sender, EventArgs e)
        {
            Logout();
        }
        
        private void Logout()
        {
            // Cria o Metodo para efetuar o logout
            BL.Login.RemoveSession();
            Application.Current.MainPage = new Inclock.View.LoginPage();
        }
    }
}