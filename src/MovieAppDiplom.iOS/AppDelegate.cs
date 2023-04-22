using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MovieAppDiplom.Core;

namespace MovieAppDiplom.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
