
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
using MovieAppDiplom.Core.Models;
using System.Collections.Generic;

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

            var movie = new Movie
            {
                Id = Guid.NewGuid(),
                Name = "Світ Дикого Заходу",
                Year = 2016,
                ImageUrl = "https://eneyida.tv/uploads/posts/2022-12/1923-2022.jpg",
                IMDBRate = 7.9,
                Genre = "НФ",
                Time = "3 сезони",
                Description = "Кинг Шульц – охотник за головами, прикрывающийся своей прошлой профессией дантиста. Шульц убивает братьев работорговцев и освобождает Джанго, чтобы тот помог ему найти трех братьев Бритл, которые в прошлом были надсмотрщиками на плантации, где раньше работал Джанго. Найдя братьев и расправившись с ними, Шульц делает предложение освобожденному рабу стать его напарником в охоте на преступников. Джанго соглашается не раздумывая, но у него есть и свои личные мотивы: найти и освободить свою любимую женщину Брумхильду, тоже рабыню, с которой их давно разлучили.",
                VideoUrl = "4McenUEna3E",
                Comments = new List<Comment>() { new Comment { CreatedTime = DateTime.Now, UserName = "Ushakov Danil", CommentValue = "Дуже кроваво!"} }
            };

/*            var firebase = new FirebaseClient("https://mymovieproject-a7c36-default-rtdb.europe-west1.firebasedatabase.app/");
            firebase
            .Child("Movies")
             .PostAsync(JsonConvert.SerializeObject(movie));*/
        }
    }
}
