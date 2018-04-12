using Inclock.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View.MasterPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public ListView lvItensMenu; // isso vai ser para torna acessivel para outras classes 
        public Master()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MasterPageItensViewModel();
            lvItensMenu = lvDetalhes;
            btnSair.Clicked += BtnSair_Clicked;
        }

        private async void BtnSair_Clicked(object sender, EventArgs e)
        {
            if (await DisplayAlert("Confirmar","Deseja realmente sair","Sim","Não"))
            {

                Thread thread = Thread.CurrentThread;
                thread.Abort();
            }
        }
    }
}