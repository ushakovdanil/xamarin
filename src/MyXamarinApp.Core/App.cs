using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MyXamarinApp.Core.ViewModels.Main;

namespace MyXamarinApp.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
