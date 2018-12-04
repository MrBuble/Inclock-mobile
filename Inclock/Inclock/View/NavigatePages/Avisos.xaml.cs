using Inclock.ViewModels;
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
    public partial class Avisos : CarouselPage
    {
        //   public ContentPage PaginaCarregamento { get; set; } = new ContentPage { };
        public AvisosViewModel ViewModel { get; set; } = new AvisosViewModel();
        public Avisos()
        {
            InitializeComponent();
            ItemsSource = ViewModel.AvisosCollection;
        }
        protected override void OnCurrentPageChanged()
        {
            ViewModel.CarregarMaisAsync(ViewModel.AvisosCollection.Count, 1);
        }
    }
}