using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BindingButtonTest.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand SecondViewCommand { get; set; }


        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            SecondViewCommand = new DelegateCommand(StartSecondView);
        }

        private void StartSecondView()
        {
            _navigationService.NavigateAsync("SecondView");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
           
        }
    }
}
