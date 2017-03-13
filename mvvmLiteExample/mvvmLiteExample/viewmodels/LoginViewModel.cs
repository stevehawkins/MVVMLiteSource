using System;
using System.Collections.Generic;
using System.Text;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using System.Windows.Input;
using System.Threading.Tasks;

namespace mvvmLiteExample.viewmodels
{
    public class LoginViewModel : ViewModelBase
    {
        private INavigationService _nav;


        // dependancy injection into the MVVM model 
        public LoginViewModel(INavigationService navi, IDialogService diag)
        {
            _nav = navi;

            // setup commands
            this.LoginCommand = new RelayCommand(CheckLogin);
        }

        #region name/pass props here

        private string _LoginPassword;
        public string LoginPassword
        {
            get { return _LoginPassword; }
            set
            {
                Set<string>(ref _LoginPassword, value, "LoginPassword");
            }
        }

        private string _LoginName;
        public string LoginName
        {
            get { return _LoginName; }
            set
            {
                Set<string>(ref _LoginName, value, "LoginName");
            }
        }
        #endregion
        #region setup any commands here

        public ICommand LoginCommand { get; private set; }
        private void CheckLogin()
        {
            // do all your login check here
        

            // asume valid so nav to start page
            _nav.NavigateTo("UserInfoView");
            // you can params as well ie. -> _nav.NavigateTo("someformname", _somedataobject);

        }


        #endregion

    }
}
