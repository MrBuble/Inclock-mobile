using Inclock.VO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Inclock.ViewModels
{
    class MasterPageItensViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<VO.MasterPageItem> MenuItems { get; set; }
        public MasterPageItensViewModel()
        {
            MenuItems = new ObservableCollection<MasterPageItem>(new[]
            {
                new MasterPageItem {Id= 0, Title = "Avisos", Icon = "PontoEntrada.png", TargetType = typeof(View.NavigatePages.Avisos) },
                new MasterPageItem {Id= 1, Title = "Entrada", Icon = "PontoEntrada.png", TargetType = typeof(View.NavigatePages.Ponto) },
                new MasterPageItem {Id= 2, Title = "Saida", Icon = "PontoSaida.png", TargetType = typeof(View.NavigatePages.Ponto) },
                new MasterPageItem {Id =98, Title= "Logout", Icon ="logout.png", TargetType= typeof(View.NavigatePages.LogoutPage) },
                new MasterPageItem {Id =99, Title= "Exit", Icon ="sair.png", TargetType= typeof(View.NavigatePages.ExitPage) }
            });
        }
        /// <summary>
        /// Terminar depois 
        /// </summary>
        /// <param name="propertyName"></param>
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(propertyName)));
            }
        }
    }
}
