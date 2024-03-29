using MovieAppDiplom.Core.Models;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;

namespace MyXamarinApp.Core.ViewModels.ChildViewModels
{
    public class MovieViewModel : MvxViewModel
    {
        private Movie _currentMovie;
        public Movie CurrentMovie
        {
            get => _currentMovie;
            set
            {
                _currentMovie = value;
                RaiseAllPropertiesChanged();
            }
        }

        public Guid Id => CurrentMovie.Id;
        public string Name => CurrentMovie.Name;
        public string MovieInfo => CurrentMovie.Year + " · " + CurrentMovie.Genre + " · " + CurrentMovie.Time;
        public string ImageUrl => CurrentMovie.ImageUrl;
        public IMvxCommand SelectMovieCommand { get; set; }

        public MovieViewModel(Movie movie)
        {
            CurrentMovie = movie;
        }
    }
}
