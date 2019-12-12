using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace App123.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {


        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        { }

            private DelegateCommand _MainPage;
        public DelegateCommand MainPage =>
            _MainPage ?? (_MainPage = new DelegateCommand(ExecuteMainPage));

        async void ExecuteMainPage()
        {
            await NavigationService.NavigateAsync("MapsPage");
        }

        }
    } 
    

