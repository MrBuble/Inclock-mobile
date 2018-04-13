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
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            MasterPage.lvItensMenu.ItemSelected += LvItensMenu_ItemSelected;
            
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(View.NavigatePages.Avisos)));
       
        }

        private void LvItensMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as VO.MasterPageItem;
            if (item == null)
                return;
            var pagina = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
            pagina.Title = item.Title;

            Detail = pagina;

            IsPresented = false;
            MasterPage.lvItensMenu.SelectedItem = null;
        }

    }
}