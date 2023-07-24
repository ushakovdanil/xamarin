using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppDiplom.Core.Models;
using MovieAppDiplom.Core.Services;
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
        private readonly IFirebaseService _firebaseService;
        public TableMoviesViewModel(IMvxNavigationService mvxNavigationService,
            IFirebaseService firebaseService)
        {
            _navigationService = mvxNavigationService;
            _firebaseService = firebaseService;

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
            IsLoading = true;
            SelectedMovieCommand = new MvxAsyncCommand<MovieViewModel>(MovieClickedAsync);
            RaiseAllPropertiesChanged();
        }
        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }
        public override async Task Initialize()
        {
            var list = await _firebaseService.GetMoviesAsync();
            IsLoading = false;
            Movies.AddRange(list.Select(movie => new MovieViewModel(movie)));
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
