using System;
using Android.App;
using Android.Views;
using MyXamarinApp.Core.ViewModels.Main;
using static Android.Content.Res.Resources;

namespace MyXamarinApp.Droid.Views.Main
{

    [Activity(
        Theme = "@style/AppTheme",
        WindowSoftInputMode = SoftInput.AdjustResize | SoftInput.StateHidden)]
    public class SecondActivity : BaseActivity<SecondActivityViewModel>
    {
        protected override int ActivityLayoutId => Resource.Layout.activity_main_container;
        
    }
}

