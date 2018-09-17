using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using page = Inclock.View.NavigatePages;

namespace Inclock.ViewModels
{
    class MenuViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<VO.MasterPageItem> Paginas;

        public MenuViewModel()
        {
            Paginas = new ObservableCollection<VO.MasterPageItem>() {
                new VO.MasterPageItem() { Title = "Avisos", TargetType = typeof(page.Avisos) },
                new VO.MasterPageItem() { Title = "Ponto", TargetType = typeof(page.Ponto) },
                new VO.MasterPageItem() { Title = "Sair", TargetType = typeof(page.LogoutPage) }
            };
        }
        #region INotifyPropertyChanged Implementation       
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
