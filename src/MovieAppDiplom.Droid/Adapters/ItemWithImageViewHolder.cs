using System;
using Android.Views;
using Android.Widget;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;

namespace Frame.App.UIHelper.Implementations
{
    public class ItemWithImageViewHolder : MvxRecyclerViewHolder
    {
        public ImageView ImageView { get; private set; }

        public ItemWithImageViewHolder(View itemView,
            IMvxAndroidBindingContext context) : base(itemView, context)
        {
            ImageView = itemView.FindViewById<ImageView>(Resource.Id.image);
        }
    }
}
