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
using Firebase;
using MovieAppDiplom.Core.ViewModels.Main;

namespace MovieAppDiplom.Droid.Views.Main
{
    [Activity(
        Theme = "@style/AppTheme",
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    public class MainContainerActivity : BaseActivity<MainContainerViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.activity_main_container;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            FirebaseApp.InitializeApp(Application.Context);

            ViewModel.NavigateTableMovies.Execute(null);
            ViewModel.NavigateNavBar.Execute(null);
        }

        public override void OnBackPressed() {
            base.OnBackPressed();
        }
    }
}
