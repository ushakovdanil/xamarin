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

namespace Frame.App.CustomBindings
{
    public class ImageViewSvgPathBinding : MvxAndroidTargetBinding
    {
        public override Type TargetType => typeof(string);

        public ImageViewSvgPathBinding(object target)
            : base(target)
        {
        }

        private Bitmap GetImageBitmapFromPath(byte[] path)
        {
            var imageBitmap = BitmapFactory.DecodeByteArray(path, 0, path.Length);
            return imageBitmap;
        }

        protected override void SetValueImpl(object target, object value)
        {
            var imageView = target as ImageView;
            var localPath = value as string;
            if (imageView is null || localPath is null)
                return;

            int id = imageView.Resources.GetIdentifier(localPath, "drawable", AppInfo.PackageName);
            imageView.SetImageResource(id);

        }
    }
}
