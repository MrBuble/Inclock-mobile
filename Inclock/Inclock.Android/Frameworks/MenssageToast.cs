using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Inclock.BL.Inteface;
using Inclock.Droid.Frameworks;

[assembly: Xamarin.Forms.Dependency(typeof(MenssageToast))]
namespace Inclock.Droid.Frameworks
{
    class MenssageToast : IToast
    {
        public void LongAlert(string Mensage)
        {
            Toast.MakeText(Application.Context, Mensage, ToastLength.Long).Show();
        }

        public void ShortAlert(string Mensage)
        {
            Toast.MakeText(Application.Context, Mensage, ToastLength.Short).Show();
        }
    }
}