using MovieAppDiplom.Core.Models;
using MovieAppDiplom.Core.ViewModels.Base;

namespace MovieAppDiplom.Core.ViewModels.ChildViewModel
{
    public class GerneViewModel : BaseViewModel
    {
        public GerneViewModel() { }

        private Genres _genre;
        public Genres Genre
        {
            get => _genre;
            set
            {
                SetProperty(ref _genre, value);
                RaiseAllPropertiesChanged();
            }
        }
        public string GenreImage => Genre switch
        {
            Genres.WarnerBros => "warner_bros",
            Genres.Paramount => "paramount",
            Genres.Disney => "disney",
            Genres.Netflix => "netflix",
            _ => "paramount"
        };
    }}
