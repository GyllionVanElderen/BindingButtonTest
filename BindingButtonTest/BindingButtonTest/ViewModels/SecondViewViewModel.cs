using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BindingButtonTest.ViewModels
{
    public class SecondViewViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand ThirdViewCommand { get; set; }


        public SecondViewViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ThirdViewCommand = new DelegateCommand(StartThirdView);
        }

        private void StartThirdView()
        {
            _navigationService.NavigateAsync("ThirdView");
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
