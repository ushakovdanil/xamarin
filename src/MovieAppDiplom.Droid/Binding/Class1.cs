using System;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Binding.Target;
using Xamarin.Essentials;
using Android.Content.Res;
using AndroidX.AppCompat.Widget;
using AndroidX.VectorDrawable.Graphics.Drawable;
using Android.Content;
using Android.App;
using MvvmCross.Binding;

namespace Frame.App.CustomBindings
{
    public class VisibleBinding : MvxAndroidTargetBinding
    {
        public override MvxBindingMode DefaultMode => MvxBindingMode.OneWay;

        public override System.Type TargetType => typeof(bool);

        public VisibleBinding(object target)
            : base(target)
        {
        }

        protected override void SetValueImpl(object target, object value)
        {
            var view = target as View;
            if (view == null || value == null)
                return;

            if((bool)value)
            {
                view.Visibility = ViewStates.Visible;
            }
            if(!(bool)value)
            {
                view.Visibility = ViewStates.Gone;
            }
        }
    }
}
