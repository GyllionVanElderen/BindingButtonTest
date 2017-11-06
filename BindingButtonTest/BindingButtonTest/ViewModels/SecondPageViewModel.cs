using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace BindingButtonTest.ViewModels
{
    public class SecondPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand ThirdViewCommand { get; set; }


        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            ThirdViewCommand = new DelegateCommand(StartThirdView);
        }

        private void StartThirdView()
        {
            _navigationService.NavigateAsync("ThirdPage");
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
