using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Frame.AppCore.Helpers;
using MovieAppDiplom.Core.Services;
using MovieAppDiplom.Core.Services.Interfaces;
using MovieAppDiplom.Core.ViewModels.Base;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MovieAppDiplom.Core.ViewModels.Main
{
    public class NavBarViewModel : BaseViewModel, IUserChangeListener
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IFirebaseService _firebaseService;
        public NavBarViewModel(IMvxNavigationService navigationService,
            IFirebaseService firebaseService)
        {
            _navigationService = navigationService;
            _firebaseService = firebaseService;
            GetMoviesCommand = new MvxAsyncCommand(async async => await NavigateSpecificMovies("movies"));
            GetCatroonsCommand = new MvxAsyncCommand(async async => await NavigateSpecificMovies("cartoons"));
            GetSeriesCommand = new MvxAsyncCommand(async async => await NavigateSpecificMovies("series"));
            ProfileCommand = new MvxAsyncCommand(async async => await _navigationService.Navigate<LoginViewModel>());
            _firebaseService.AddUserChangedListener(this);
            UserName = Settings.Username ?? "Guest";
        }        

        public MvxAsyncCommand GetMoviesCommand { get; set; }
        public MvxAsyncCommand GetCatroonsCommand { get; set; }
        public MvxAsyncCommand GetSeriesCommand { get; set; }

        public MvxAsyncCommand ProfileCommand { get; set; }

        public void UserChanged(string user)
        {
            UserName = user;
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                RaiseAllPropertiesChanged();
            }
        }

        private async Task NavigateSpecificMovies(string str)
        {
            await _navigationService.Navigate<TableMoviesViewModel>();
        }

    }
}
