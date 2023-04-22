using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace MovieAppDiplom.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.main_content)]
    public class MainFragment : BaseFragment<TableMoviesViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.table_movies;
    }
}
