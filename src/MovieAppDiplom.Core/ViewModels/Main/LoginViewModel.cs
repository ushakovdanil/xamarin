using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieAppDiplom.Core.Models;
using MovieAppDiplom.Core.Services;
using MovieAppDiplom.Core.ViewModels.Base;
using MvvmCross.Commands;
using MvvmCross.Navigation;

namespace MovieAppDiplom.Core.ViewModels.Main
{
    public class LoginViewModel: BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly IFirebaseService _firebaseService;
        public LoginViewModel(IMvxNavigationService mvxNavigationService,
            IFirebaseService firebaseService)
        {
            _firebaseService = firebaseService;
            _navigationService = mvxNavigationService;
            BackCommand = new MvxAsyncCommand(async () => await _navigationService.Close(this));
            LoginCommand = new MvxAsyncCommand(LoginAsync);
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

        private string _userPassword;
        public string UserPassword
        {
            get => _userPassword;
            set
            {
                _userPassword = value;
                RaiseAllPropertiesChanged();
            }
        }

        private async Task LoginAsync()
        {
            User user = new User()
            {
                Name = UserName,
                Password = UserPassword
            };
            await _firebaseService.Login(user);
            await _navigationService.Close(this);
        }
        public MvxAsyncCommand BackCommand { get; set; }
        public MvxAsyncCommand LoginCommand { get; set; }


    }
}
