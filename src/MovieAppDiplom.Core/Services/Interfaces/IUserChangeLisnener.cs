using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppDiplom.Core.Services.Interfaces
{
    public interface IUserChangeListener
    {
        public void UserChanged(string user);
    }
}
