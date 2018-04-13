using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using Inclock.iOS.Frameworks;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(MmenssageToast))]
namespace Inclock.iOS.Frameworks
{
    public class MmenssageToast : BL.Inteface.IToast
    {

        private UIAlertController Alert;
        private NSTimer Delay;
        private const double SHORT_DELAY = 2.0;
        private const double LONG_DELAY = 3.5;
        public void LongAlert(string Mensage)
        {
            ShowAlert(Mensage, LONG_DELAY);
        }

        public void ShortAlert(string Mensage)
        {
            ShowAlert(Mensage, SHORT_DELAY);
        }


        private void ShowAlert(string Mensage, double seconds)
        {
            Delay = NSTimer.CreateScheduledTimer(seconds, (obj) =>
            {
                DismissMessage();
            });
            Alert = UIAlertController.Create(null, Mensage, UIAlertControllerStyle.Alert);
            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(Alert, true, null);
        }
        void DismissMessage()
        {
            if (Alert != null)
            {
                Alert.DismissViewController(true, null);
            }
            if (Delay != null)
            {
                Delay.Dispose();
            }
        }
    }
}