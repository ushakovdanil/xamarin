using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MovieAppDiplom.Core.ViewModels.Main;

namespace MovieAppDiplom.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainContainerViewModel>();
        }
    }
}
