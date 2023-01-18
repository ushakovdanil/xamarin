using Foundation;
using MvvmCross.Platforms.Ios.Core;
using MyXamarinApp.Core;

namespace MyXamarinApp.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
    }
}
