using System;
using System.Collections.Generic;
using System.Text;
using MovieAppDiplom.Core.ViewModels.Base;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MovieAppDiplom.Core.ViewModels.Main
{
    public class MainContainerViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public MainContainerViewModel(IMvxNavigationService mvxNavigationService)
        {
            _navigationService = mvxNavigationService;
            NavigateTableMovies = new MvxAsyncCommand(async async => await _navigationService.Navigate<TableMoviesViewModel>());
        }

        public IMvxAsyncCommand NavigateTableMovies { get; set; }
    }
}
