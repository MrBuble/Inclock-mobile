using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using ZXing.QrCode;
using System.Threading.Tasks;
using Xamarin.Forms;
using Inclock.BL.Inteface;

namespace Inclock.ViewModels
{
    public class GetQrViewModel : INotifyPropertyChanged
    {
        public ZXing.Result result { get; set; }
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
        public Command QRScanResultCommand
        {
            get
            {
                return new Command(() =>
                {               
                    Device.BeginInvokeOnMainThread( () =>
                    {
                         DependencyService.Get<IToast>().ShortAlert(result.Text);
                        //do your job here - Result.Text contains QR CODE
                    });
                });
            }
        }
    }
}
