
using Android.App;
using Android.OS;
using Android.Views;
using Android.Flexbox;
using AndroidX.RecyclerView.Widget;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using Firebase.Database;
using Firebase;
using System;
using MovieAppDiplom.Droid.Models;
using AndroidX.Core.App;
using static Java.Util.Jar.Attributes;
using Newtonsoft.Json;

namespace MovieAppDiplom.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.main_content)]
    public class TableMoviesFragment : BaseFragment<TableMoviesViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.table_movies;

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            var recycler = view.FindViewById<MvxRecyclerView>(Resource.Id.movies_recycler);
            recycler.HasFixedSize = false;
            var layoutManager = new FlexboxLayoutManager(context: Activity);
            layoutManager.JustifyContent = JustifyContent.Center;
            recycler.SetLayoutManager(layoutManager);

            var genresRecycler = view.FindViewById<MvxRecyclerView>(Resource.Id.genres_recycler);
            genresRecycler.SetLayoutManager(new LinearLayoutManager(Activity, LinearLayoutManager.Horizontal, false));
            genresRecycler.HasFixedSize = false;

            var movie = new MovieDto
            {
                Id = Guid.NewGuid(),
                Name = "Titanic",
                Year = 1994,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/d/de/%D0%A4%D0%BE%D1%80%D1%80%D0%B5%D1%81%D1%82_%D0%93%D0%B0%D0%BC%D0%BF.jpg",
                IMDBRate = 9.21,
                Genre = "Drama",
                Time = "2г 2х"
            };


            var firebase = new FirebaseClient("https://mymovieproject-a7c36-default-rtdb.europe-west1.firebasedatabase.app/");
            firebase
            .Child("Movies")
             .PostAsync(JsonConvert.SerializeObject(movie));
        }
    }
}
