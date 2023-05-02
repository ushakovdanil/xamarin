using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MovieAppDiplom.Core.Models;
using MovieAppDiplom.Core.ViewModels.Base;
using MovieAppDiplom.Core.ViewModels.ChildViewModel;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using MyXamarinApp.Core.ViewModels.ChildViewModels;

namespace MovieAppDiplom.Core.ViewModels.Main
{
    public class TableMoviesViewModel : BaseViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        public TableMoviesViewModel(IMvxNavigationService mvxNavigationService)
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
                        ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1000_.jpg",
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
                        ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzA5ZDNlZWMtM2NhNS00NDJjLTk4NDItYTRmY2EwMWZlMTY3XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1000_.jpg",
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
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/thumb/6/6f/%D0%94%D0%B6%D0%BE%D0%BA%D0%B5%D1%80_%28%D1%84%D0%B8%D0%BB%D1%8C%D0%BC_%D0%A2%D0%BE%D0%B4%D0%B4%D0%B0_%D0%A4%D0%B8%D0%BB%D0%BB%D0%B8%D0%BF%D1%81%D0%B0%29.jpg/640px-%D0%94%D0%B6%D0%BE%D0%BA%D0%B5%D1%80_%28%D1%84%D0%B8%D0%BB%D1%8C%D0%BC_%D0%A2%D0%BE%D0%B4%D0%B4%D0%B0_%D0%A4%D0%B8%D0%BB%D0%BB%D0%B8%D0%BF%D1%81%D0%B0%29.jpg",
                        Genre ="Drama",
                        Time = "2г 2х"
                    }
                },
                 new MovieViewModel{ CurrentMovie = new Movie
                    {
                        Id = Guid.NewGuid(),
                        Name = "Titanic",
                        Year = 1994,
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/d/de/%D0%A4%D0%BE%D1%80%D1%80%D0%B5%D1%81%D1%82_%D0%93%D0%B0%D0%BC%D0%BF.jpg",
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
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/d/de/%D0%A4%D0%BE%D1%80%D1%80%D0%B5%D1%81%D1%82_%D0%93%D0%B0%D0%BC%D0%BF.jpg",
                        IMDBRate = 9.21,
                        Genre ="Drama",
                        Time = "2г 2х"
                    }
                }
            });

            GenreMovies.AddRange(new List<GerneViewModel>()
            {
                new GerneViewModel()
                {
                    Genre = Genres.WarnerBros
                },
                new GerneViewModel()
                {
                    Genre = Genres.Disney
                },
                new GerneViewModel()
                {
                    Genre = Genres.Paramount
                },
                new GerneViewModel()
                {
                    Genre = Genres.Netflix
                },
            });
            SelectedMovieCommand = new MvxAsyncCommand<MovieViewModel>(MovieClickedAsync);

            RaiseAllPropertiesChanged();
        }
        public MvxObservableCollection<MovieViewModel> Movies { get; set; } = new MvxObservableCollection<MovieViewModel>();

        public MvxObservableCollection<GerneViewModel> GenreMovies { get; set; } = new MvxObservableCollection<GerneViewModel>();

        public MvxAsyncCommand<MovieViewModel> SelectedMovieCommand { get; set; }

        private async Task MovieClickedAsync(MovieViewModel movie)
        {
            await _navigationService.Navigate<MovieDetailsViewModel, Movie>(movie.CurrentMovie);
        }

        public MvxAsyncCommand Navigate { get; set; }
    }
}
