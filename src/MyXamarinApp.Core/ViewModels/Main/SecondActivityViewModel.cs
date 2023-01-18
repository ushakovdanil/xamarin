using System;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MyXamarinApp.Core.ViewModels.Main
{
    public class SecondActivityViewModel: BaseViewModel
    {
        private readonly IMvxNavigationService _mvxNavigationService;

        public SecondActivityViewModel(IMvxNavigationService mvxNavigationService)
        {
            _mvxNavigationService = mvxNavigationService;
            Navigate = new MvxAsyncCommand(async () => await _mvxNavigationService.Navigate<MainContainerViewModel>());
        }

        public string Title => "Друга Актівіті";

        public MvxAsyncCommand Navigate { get; set; }

    }
}

