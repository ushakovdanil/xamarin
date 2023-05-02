using System;
using System.Collections.Generic;
using System.Text;
using MovieAppDiplom.Core.Models;
using MovieAppDiplom.Core.ViewModels.Base;

namespace MovieAppDiplom.Core.ViewModels.Main
{
    public class MovieDetailsViewModel : BaseViewModel<Movie>
    {
        public MovieDetailsViewModel() { }

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
        public string ImageUrl => CurrentMovie.ImageUrl;
        public override void Prepare(Movie parameter)
        {
            CurrentMovie = parameter;
        }
    }
}
