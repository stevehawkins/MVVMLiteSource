using Microsoft.Practices.ServiceLocation;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using mvvmLiteExample.viewmodels;

namespace mvvmLiteExample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginView : ContentPage
	{
		private LoginViewModel vm;

		public LoginView ()
		{
			InitializeComponent ();
			vm = (LoginViewModel)ServiceLocator.Current.GetInstance(typeof(LoginViewModel));
			this.BindingContext = vm;
		}
	}
}
