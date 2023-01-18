using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.Navigation;


namespace MyXamarinApp.Core.ViewModels.Main
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _mvxNavigationService;

        public MainViewModel(IMvxNavigationService mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
            Navigate = new MvxAsyncCommand(async () => await _mvxNavigationService.Navigate<SecondActivityViewModel>());
        }
        public string Title => "Перша Актівіті";

        public MvxAsyncCommand Navigate { get; set; }
    }
}
