using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieAppDiplom.Core.ViewModels.Base;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MovieAppDiplom.Core.ViewModels.Main
{
    public class NavBarViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public NavBarViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            GetMoviesCommand = new MvxAsyncCommand(async async => await NavigateSpecificMovies("movies"));
            GetCatroonsCommand = new MvxAsyncCommand(async async => await NavigateSpecificMovies("cartoons"));
            GetSeriesCommand = new MvxAsyncCommand(async async => await NavigateSpecificMovies("series"));


        }

        public MvxAsyncCommand GetMoviesCommand { get; set; }
        public MvxAsyncCommand GetCatroonsCommand { get; set; }
        public MvxAsyncCommand GetSeriesCommand { get; set; }

        private async Task NavigateSpecificMovies(string str)
        {
            await _navigationService.Navigate<TableMoviesViewModel>();
        }

    }
}
