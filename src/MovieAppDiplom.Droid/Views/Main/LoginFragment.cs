using System;

using Android.App;
using Android.OS;
using Android.Views;
using AndroidX.ConstraintLayout.Widget;
using AndroidX.RecyclerView.Widget;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Presenters.Attributes;

namespace MovieAppDiplom.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.login)]
    public class LoginFragment : BaseFragment<LoginViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.user_login_layout;

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            var main = View.FindViewById<ConstraintLayout>(Resource.Id.main_content);

            main.Click += Main_layout_Click;
        }

        private void Main_layout_Click(object sender, EventArgs e)
        {
            ViewModel.BackCommand.Execute(null);
        }
    }
}
