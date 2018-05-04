using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inclock.View.NavigatePages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Avisos : CarouselPage
	{
		public Avisos ()
		{
			InitializeComponent ();
            ItemsSource = new ViewModels.AvisosViewModel().AvisosCollection;
		}
	}
}