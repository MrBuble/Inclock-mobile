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
    public partial class Menu : MasterDetailPage
    {
        public Menu(string user = "")
        {
            InitializeComponent();
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(View.NavigatePages.Avisos)));
            MastePage.ListView.ItemSelected += ListView_ItemSelected;
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (!(e.SelectedItem is VO.MasterPageItem item))
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MastePage.ListView.SelectedItem = null;
        }
    }
}