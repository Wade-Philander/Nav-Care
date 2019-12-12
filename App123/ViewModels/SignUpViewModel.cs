using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App123.ViewModels
{
    public class SignUpViewModel : ViewModelBase
    {
        private DelegateCommand _MainPage;
        public DelegateCommand MainPage =>
            _MainPage ?? (_MainPage = new DelegateCommand(ExecuteMainPage));

        async void ExecuteMainPage()
        {
            await NavigationService.NavigateAsync("MainPage");
        }
        public SignUpViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            

        }
    }
}
