using Microsoft.Practices.ServiceLocation;
using mvvmLiteExample.viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mvvmLiteExample.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserInfoView : ContentPage
	{
		public UserInfoView ()
		{
			InitializeComponent ();
            this.BindingContext = (UserInfoViewModel)ServiceLocator.Current.GetInstance(typeof(UserInfoViewModel));
		}
	}
}
