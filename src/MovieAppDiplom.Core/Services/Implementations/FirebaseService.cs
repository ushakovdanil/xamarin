using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Firebase;
using Firebase.Database;
using MovieAppDiplom.Core.Models;
using System.Reactive.Threading.Tasks;
using System.Reactive.Linq;
using System.Threading.Tasks;
using Frame.AppCore.Helpers;
using MovieAppDiplom.Core.Services.Interfaces;
using Newtonsoft.Json;

namespace MovieAppDiplom.Core.Services
{
    public class FirebaseService : IFirebaseService
    {
        private readonly FirebaseClient _client;

        private Action<string> _userChangedAction { get; set; }
        public FirebaseService()
        {
            _client = new FirebaseClient("https://mymovieproject-a7c36-default-rtdb.europe-west1.firebasedatabase.app/");
        }

        public async Task<List<Movie>> GetMoviesAsync()
        {
            var movies = (await _client
            .Child("Movies").OnceAsync<Movie>()).Select(movie => new Movie(movie)).ToList();
            return movies;
        }

        public async Task<bool> Login(User user)
        {
            var movies = (await _client
                .Child("Users").OnceAsync<User>()).Select(fbUser => fbUser.Object.Name == user.Name && fbUser.Object.Password == user.Password).FirstOrDefault();

            if(!movies)
            {
                await _client
                .Child("Users")
                 .PostAsync(JsonConvert.SerializeObject(user));
            }

            Settings.Username = user.Name;
            NotifyUserChanged(Settings.Username);

            return true;
        }

        public void AddUserChangedListener(IUserChangeListener listener)
        {
            _userChangedAction += listener.UserChanged;
        }
        public void RemoveUserChangedListener(IUserChangeListener listener)
        {
            _userChangedAction -= listener.UserChanged;
        }

        private void NotifyUserChanged(string name)
        {
            _userChangedAction.Invoke(name);
        }
    }
}
