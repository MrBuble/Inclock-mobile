using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using ZXing.QrCode;
using System.Threading.Tasks;
namespace Inclock.ViewModels
{
    public class GetQrViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string stQrCode;
        public string StQrCode
        {
            get { return stQrCode; }
            set
            {
                stQrCode = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(StQrCode)));
            }
        }
        public GetQrViewModel()
        {

        }
    }
}
