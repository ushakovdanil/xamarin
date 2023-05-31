using System;
using System.Collections.Generic;
using System.Text;
using Frame.AppCore.Helpers;
using MovieAppDiplom.Core.Models;
using MovieAppDiplom.Core.ViewModels.Base;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MovieAppDiplom.Core.ViewModels.Main
{
    public class MovieDetailsViewModel : BaseViewModel<Movie>
    {
        public MovieDetailsViewModel() {
            AddMovieCommentCommand = new MvxCommand(AddComment);
        }

        private Movie _currentMovie;
        public Movie CurrentMovie
        {
            get => _currentMovie;
            set
            {
                _currentMovie = value;
                MovieComments.AddRange(value.Comments);
                RaiseAllPropertiesChanged();
            }
        }
        public MvxObservableCollection<Comment> MovieComments { get; set; } = new MvxObservableCollection<Comment>();

        public string ImageUrl => CurrentMovie.ImageUrl;
        public override void Prepare(Movie parameter)
        {
            CurrentMovie = parameter;
        }

        public MvxCommand AddMovieCommentCommand { get; set; }

        private void AddComment()
        {
            var currentComment = new Comment()
               {
                    UserName = string.IsNullOrEmpty(Settings.Username) ? "Guest" : Settings.Username,
                    CreatedTime = DateTime.Now,
                    CommentValue = CommentValue
            };

            MovieComments.Add(currentComment);
            RaisePropertyChanged(() => MovieComments);
        }

        private string _commentValue;
        public string CommentValue
        {
            get => _commentValue;
            set => SetProperty(ref _commentValue, value);
        }
    }
}
