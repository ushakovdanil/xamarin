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
using Android.Flexbox;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using Frame.App.UIHelper.Implementations;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace MovieAppDiplom.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.main_content)]
    public class MovieDetailsFragment : BaseFragment<MovieDetailsViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.movie_details_layout;

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
        }
    }
}
