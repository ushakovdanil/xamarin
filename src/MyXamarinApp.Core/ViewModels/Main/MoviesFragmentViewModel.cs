using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MyXamarinApp.Core.ViewModels.ChildViewModels;

namespace MyXamarinApp.Core.ViewModels.Main
{
    public class MoviesFragmentViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MoviesFragmentViewModel(IMvxNavigationService mvxNavigationService)
        {
            _navigationService = mvxNavigationService;
            Movies.AddRange(new List<MovieViewModel>()
            {
                new MovieViewModel{ CurrentMovie = new Movie
                    {
                        Id = Guid.NewGuid(),
                        Name = "Titanic",
                        Year = 1994,
                        IMDBRate = 9.21,
                        Genre ="Drama",
                        Time = "2г 2х"
                    }
                },
                new MovieViewModel{ CurrentMovie = new Movie
                    {
                        Id = Guid.NewGuid(),
                        Name = "Titanic",
                        Year = 1994,
                        IMDBRate = 9.21,
                        Genre ="Drama",
                        Time = "2г 2х"
                    }
                },
                 new MovieViewModel{ CurrentMovie = new Movie
                    {
                        Id = Guid.NewGuid(),
                        Name = "Titanic",
                        Year = 1994,
                        IMDBRate = 9.21,
                        Genre ="Drama",
                        Time = "2г 2х"
                    }
                },
                new MovieViewModel{ CurrentMovie = new Movie
                    {
                        Id = Guid.NewGuid(),
                        Name = "Titanic",
                        Year = 1994,
                        IMDBRate = 9.21,
                        Genre ="Drama",
                        Time = "2г 2х"
                    }
                }
            });
        }
        public MvxObservableCollection<MovieViewModel> Movies { get; set; } = new MvxObservableCollection<MovieViewModel>();
        public MvxAsyncCommand Navigate { get; set; }
    }
}
