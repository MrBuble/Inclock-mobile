using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using page = Inclock.View.NavigatePages;

namespace Inclock.ViewModels
{
    class MenuViewModel 
    {
        public ObservableCollection<VO.MasterPageItem> Paginas;

        public MenuViewModel()
        {
            Paginas = new ObservableCollection<VO.MasterPageItem>() {
                new VO.MasterPageItem() { Title = "Avisos", TargetType = typeof(page.Avisos) },
                new VO.MasterPageItem() { Title = "Ponto", TargetType = typeof(page.Ponto) },
                new VO.MasterPageItem() { Title = "Sair", TargetType = typeof(page.LogoutPage) }
            };
        }
    }
}
