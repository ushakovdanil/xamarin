
using Android.App;
using Android.OS;
using Android.Views;
using Android.Flexbox;
using AndroidX.RecyclerView.Widget;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Presenters.Attributes;

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
        }
    }
}
