using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Inclock.VO
{
    public class Aviso : INotifyPropertyChanged
    {
        private int _id { get; set; }
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;
                PropertyChanged?.Invoke();
            }
        }
        private string _imagem { get; set; }
        public string Imagem { get; set; }
        private string _titulo { get; set; }
        public string Titulo { get; set; }
        private string _conteudo { get; set; }
        public string Conteudo { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
