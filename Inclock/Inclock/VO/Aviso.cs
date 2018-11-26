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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ID)));
            }
        }
        private string _imagem { get; set; }
        public string Imagem
        {
            get { return _imagem; }
            set
            {
                _imagem = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Imagem)));
            }
        }

        private string _titulo { get; set; }

        public string Titulo
        {
            get { return _titulo; }
            set
            {
                _titulo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Titulo)));
            }
        }
        private string _conteudo { get; set; }
        public string Conteudo
        {
            get { return _conteudo; }
            set
            {
                _conteudo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Titulo)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
