using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmsCollectionApp.BLL;
using FilmsCollectionApp.Models;
using FilmsCollectionApp.DAL;

namespace FilmsCollectionApp.BLL
{
    public class FavFilmsBehavior
    {
        private IFavouriteFilmRepository favouriteFilmRepository;
        private IFilmsRepository filmsrepo;
        private IUnitOfWork unitOfWork;
        public FavFilmsBehavior()
        {
            filmsrepo = new FilmsRepository(new FilmsCollectionDBContext());
            favouriteFilmRepository = new FavouriteFilmRepository(new FilmsCollectionDBContext());
            unitOfWork = new UnitOfWork(new FilmsCollectionDBContext());
        }

        public IEnumerable<Films> GetListOfFavoriteFilms()
        {
            var AllFavFilms = favouriteFilmRepository.GetAll();
            List<Films> films = new List<Films>();
            foreach (var el in AllFavFilms)
            {            
                el.Film = filmsrepo.Get(el.FilmId ?? default(int));
                films.Add(el.Film);
            }
            
            return films;
        }
    }
}
