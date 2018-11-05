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
        private ZXing.Result result;
        public ZXing.Result Result
        {
            get { return result; }
            set
            {
                result = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
            }
        }
        private bool isAnalyzing = true;
        public bool IsAnalyzing
        {
            get { return isAnalyzing; }
            set
            {
                isAnalyzing = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsAnalyzing)));
            }
        }

        private bool isScanning = true;
        public bool IsScanning
        {
            get { return isScanning; }
            set
            {
                isScanning = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsScanning)));
            }
        }
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
        private Command command;
        public Command QRScanResultCommand
        {
            get
            {
                return new Command((xl) =>
                {
                    var xd = xl;
                    IsAnalyzing = false;
                    IsScanning = false;
                    Device.BeginInvokeOnMainThread(() =>
                   {
                       DependencyService.Get<IToast>().ShortAlert(Result.Text);

                   });
                });
            }
            set {
                command = value;
            }
        }
    }
}
