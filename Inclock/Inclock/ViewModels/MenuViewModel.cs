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
                new VO.MasterPageItem() { Title = "Avisos", TargetType = typeof(page.Avisos),Icon = "alerta.png" },
                new VO.MasterPageItem() { Title = "Bater Entrada", TargetType = typeof(page.Ponto), Icon = "PontoEntrada.png" },
                new VO.MasterPageItem() { Title = "Bater Saida", TargetType = typeof(page.Ponto), Icon = "PontoSaida.png" },
                new VO.MasterPageItem() { Title = "Logout", TargetType = typeof(page.LogoutPage), Icon = "sair.png"}
            };
        }
    }
}
