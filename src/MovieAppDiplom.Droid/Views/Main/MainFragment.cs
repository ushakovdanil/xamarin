using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Telephony;
using Android.Views;
using Android.Widget;
using AndroidX.RecyclerView.Widget;
using Frame.App.UIHelper.Implementations;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;
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
            recycler.SetLayoutManager(new GridLayoutManager(Application.Context, spanCount: 4));
            //recycler.Adapter = new MovieClassAdapter(this, ViewModel, (IMvxAndroidBindingContext)BindingContext);
        }

    }
}
