using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieAppDiplom.Core.Models;

namespace MovieAppDiplom.Core.Services
{
    public interface IFirebaseService
    {
        public Task<List<Movie>> GetMoviesAsync();
    }
}
