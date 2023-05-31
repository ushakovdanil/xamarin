using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppDiplom.Core.Models;
using MovieAppDiplom.Core.Services.Interfaces;

namespace MovieAppDiplom.Core.Services
{
    public interface IFirebaseService
    {
        public Task<List<Movie>> GetMoviesAsync();
        public Task<bool> Login(User user);

        public void AddUserChangedListener(IUserChangeListener listener);
        public void RemoveUserChangedListener(IUserChangeListener listener);
    }
}
