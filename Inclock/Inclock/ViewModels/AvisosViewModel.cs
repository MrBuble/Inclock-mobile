using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace Inclock.ViewModels
{
    public class AvisosViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<VO.Aviso> AvisosCollection { get; set; }
        public AvisosViewModel()
        {
            AvisosCollection = new ObservableCollection<VO.Aviso> {
                new VO.Aviso{ Titulo ="Teste" ,Imagem="http://raw.github.com/Redth/ZXing.Net.Mobile/master/Art/ZXing.Net.Mobile-Icon.png"},
                new VO.Aviso {Conteudo =  "Teste2", Imagem = "https://avatars3.githubusercontent.com/u/271950?s=60&v=4"}
            };
        }
    }
}
