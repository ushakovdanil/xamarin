using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace MovieAppDiplom.Core.ViewModels.Base
{
    public abstract class BaseViewModel<TParameter, TResult> : BaseViewModelResult<TResult>, IMvxViewModel<TParameter, TResult>
        where TParameter : notnull
        where TResult : notnull
    {
        public abstract void Prepare(TParameter parameter);
    }
}
