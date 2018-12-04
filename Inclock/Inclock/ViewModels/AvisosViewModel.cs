using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Inclock.ViewModels
{
    public class AvisosViewModel
    {
        public ICommand command { get; set; }
        public ObservableCollection<VO.Aviso> AvisosCollection { get; set; } = new ObservableCollection<VO.Aviso>();
        public AvisosViewModel()
        {
            CarregarMaisAsync(0, 1);
        }

        public async void CarregarMaisAsync(int index, int qtede)
        {
            using (var client = new BL.Rest.Client())
            {
                var avisos = await client.GetAvisos(qtede, index);
                foreach (var item in avisos)
                {
                    AvisosCollection.Add(item);
                }
            }

        }
    }
}
