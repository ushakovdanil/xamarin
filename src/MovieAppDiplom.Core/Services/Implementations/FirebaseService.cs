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

namespace MovieAppDiplom.Core.Services
{
    public class FirebaseService : IFirebaseService
    {
        private readonly FirebaseClient _client;

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
    }
}
