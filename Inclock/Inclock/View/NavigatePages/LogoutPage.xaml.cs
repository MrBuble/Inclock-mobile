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

        }
        /// <summary>
        /// Falta terminar isso, pois 
        /// </summary>
        private void Logout()
        {
            // Cria o Metodo para efetuar o logout
            App.Current.MainPage = new Inclock.View.LoginPage();
        }
    }
}