using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Views;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using System.ComponentModel;
using YouTube.Player;

namespace MovieAppDiplom.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.main_content)]
    public class MovieDetailsFragment : BaseFragment<MovieDetailsViewModel>, YouTubeThumbnailView.IOnInitializedListener, IYouTubeThumbnailLoaderOnThumbnailLoadedListener
    {
        protected override int FragmentLayoutId => Resource.Layout.movie_details_layout;
        private string _apiKey => "AIzaSyAhUnl3ZCmoLHqib-7zhwQc_u0MRAPGBi4";

        private YouTubeThumbnailView _youTubePlayerView;

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            _youTubePlayerView = view.FindViewById<YouTubeThumbnailView>(Resource.Id.youtube_thumbnail);

            _youTubePlayerView.Initialize(_apiKey, this);

            ViewModel.PropertyChanged += ViewModel_PropertyChanged;
            _youTubePlayerView.Click += (object obj, EventArgs args) =>
            {
                Intent intent = YouTubeStandalonePlayer.CreateVideoIntent(Activity, _apiKey, ViewModel.CurrentMovie.VideoUrl);
                Activity.StartActivity(intent);
            };

        }

        private void ViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ViewModel.CurrentMovie.VideoUrl))
            {
                YouTubeStandalonePlayer.CreateVideoIntent(Activity, _apiKey, ViewModel.CurrentMovie.VideoUrl);
            }
        }

        private IYouTubeThumbnailLoader _youTubeThumbnailLoader;
        public void OnInitializationFailure(YouTubeThumbnailView p0, YouTubeInitializationResult p1) { }
        public void OnInitializationSuccess(YouTubeThumbnailView p0, IYouTubeThumbnailLoader p1)
        {
            p1.SetVideo(ViewModel.CurrentMovie.VideoUrl);
            _youTubeThumbnailLoader = p1;
            p1.SetOnThumbnailLoadedListener(this);
        }

        public void OnThumbnailError(YouTubeThumbnailView p0, YouTubeThumbnailLoaderErrorReason p1) => throw new NotImplementedException();
        public void OnThumbnailLoaded(YouTubeThumbnailView p0, string p1)
        {
            _youTubeThumbnailLoader.Release();
        }
    }
}
