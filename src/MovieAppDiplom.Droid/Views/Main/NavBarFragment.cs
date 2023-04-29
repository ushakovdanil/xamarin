using Android.App;
using Android.OS;
using Android.Views;
using AndroidX.RecyclerView.Widget;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace MovieAppDiplom.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.top_bar)]
    public class NavBarFragment : BaseFragment<NavBarViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.top_nav_bar_layout;

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

        }
    }
}
