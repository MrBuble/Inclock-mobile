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
    public partial class ExitPage : ContentPage
    {
        public ExitPage()
        {
            InitializeComponent();
            Sair();

        }
        private async void Sair()
        {
            Environment.Exit(0);
            if (await DisplayAlert("Sair", "Deseja realmente sair?", "Sim", "Não"))
            {
                Environment.Exit(0);
            }
            else
               await Navigation.PopToRootAsync();
        }
    }


}