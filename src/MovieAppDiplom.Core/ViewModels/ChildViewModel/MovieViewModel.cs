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
        public string Title => CurrentMovie.Title;

        public string Description => CurrentMovie.Description;
        public int MyProperty { get; set; }
        public IMvxCommand AddToSavedClassCommand { get; set; }
    }
}
