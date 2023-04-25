using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using Bumptech.Glide;
using Bumptech.Glide.Load.Engine;
using Bumptech.Glide.Request;
using MovieAppDiplom.Core.ViewModels.Main;
using MvvmCross.DroidX.RecyclerView;
using MvvmCross.Platforms.Android.Binding.BindingContext;
using MvvmCross.ViewModels;
using MyXamarinApp.Core.ViewModels.ChildViewModels;

namespace Frame.App.UIHelper.Implementations
{
    public class MovieClassAdapter : MvxRecyclerAdapter
    {
        public TableMoviesViewModel mViewModel;
        private Fragment mFragment;

        public MovieClassAdapter(Fragment fragment,
            TableMoviesViewModel viewModel,
            IMvxAndroidBindingContext bindingContext)
        : base(bindingContext)
        {
            mViewModel = viewModel;
            mFragment = fragment;
        }

        private RequestOptions _requestOptions = RequestOptions.DiskCacheStrategyOf(DiskCacheStrategy.All);

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            base.OnBindViewHolder(holder, position);

            var imageView = (holder as ItemWithImageViewHolder)?.ImageView;
            if (imageView != null)
            {
                Glide.With(mFragment)
                    .Load(mViewModel.Movies[position]?.ImageUrl)
                    .Apply(_requestOptions)
                    .Into(imageView);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemBindingContext = new MvxAndroidBindingContext(parent.Context, this.BindingContext.LayoutInflaterHolder);
            var view = this.InflateViewForHolder(parent, viewType, itemBindingContext);

            return new ItemWithImageViewHolder(view, itemBindingContext);
        }
    }
}

