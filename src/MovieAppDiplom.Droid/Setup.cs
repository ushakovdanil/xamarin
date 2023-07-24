using Microsoft.Extensions.Logging;
using MvvmCross.Platforms.Android.Core;
using MovieAppDiplom.Core;
using Serilog;
using Serilog.Extensions.Logging;
using MvvmCross.Binding.Bindings.Target.Construction;
using Android.Widget;
using Frame.App.CustomBindings;
using Android.Views;

namespace MovieAppDiplom.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        protected override ILoggerProvider CreateLogProvider() => new SerilogLoggerProvider();


        protected override void FillTargetFactories(IMvxTargetBindingFactoryRegistry registry)
        {
            base.FillTargetFactories(registry);

            registry.RegisterCustomBindingFactory<ImageView>("LocalImagePath", view => new ImageViewSvgPathBinding(view));
            registry.RegisterCustomBindingFactory<View>("Visible", view => new VisibleBinding(view));


        }
        protected override ILoggerFactory CreateLogFactory()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();

            return new SerilogLoggerFactory();
        }
    }
}
