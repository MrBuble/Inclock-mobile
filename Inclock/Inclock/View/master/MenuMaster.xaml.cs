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

            BindingContext = new ViewModels.MenuViewModel();
            ListView = MenuItemsListView;
        }
	}
}