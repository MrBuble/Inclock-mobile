using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View.master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuMaster : ContentPage
    {
        public ListView ListView;
        public MenuMaster ()
		{
			InitializeComponent ();
        
            ListView = MenuItemsListView;
            ListView.ItemsSource = new ViewModels.MenuViewModel().Paginas;
        }
	}
}