using System;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using mvvmLiteExample.viewmodels;
using mvvmLiteExample.Views;

namespace mvvmLiteExample
{
    public class ServiceMdl
    {
        public mvvmLiteExample.helpers.NavigationService navigationService;

        public ServiceMdl()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // add models and forms here
            this.RegisterIOCServices();
            this.RegisterViews();
            this.RegisterViewModels();
        }

        public void RegisterViewModels()
        {
            // reg common view models
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<UserInfoViewModel>();
        }

        private void RegisterIOCServices()
        {
            // register services here
            navigationService = new mvvmLiteExample.helpers.NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationService);

        }

        private void RegisterViews()
        {
            // views
            navigationService.Configure("UserInfoView", typeof(UserInfoView));
            navigationService.Configure("LoginView", typeof(LoginView));

        }
    }
}
