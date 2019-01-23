using Microsoft.AspNetCore.Mvc;
using FilmsCollectionApp.Models;
using FilmsCollectionApp.DAL;
using FilmsCollectionApp.BLL;

namespace FilmsCollectionApp.Controllers
{
    public class FavouriteFilmsController : Controller
    {
        private IFavouriteFilmRepository favouriteFilmRepository;
        private IFilmsRepository filmsrepo;
        private IUnitOfWork unitOfWork;
        FavFilmsBehavior favfilms;
        public FavouriteFilmsController()
        {
            filmsrepo = new FilmsRepository(new FilmsCollectionDBContext());
            favouriteFilmRepository = new FavouriteFilmRepository(new FilmsCollectionDBContext());
            unitOfWork = new UnitOfWork(new FilmsCollectionDBContext());
            favfilms = new FavFilmsBehavior();
        }
        public IActionResult Index()
        {
            ViewBag.FavouriteFilms = favfilms.GetListOfFavoriteFilms();
            return View();
        }

        public ViewResult AddToFavFilms(string filmname)
        {
            ViewBag.currentfilm = filmname;
            using (var un = new UnitOfWork(new FilmsCollectionDBContext()))
            {
                un.FavouriteFilm.AddToFavFilms(filmname);
                un.Complete();
            }
            return View();
        }

        public ViewResult RemoveFromFavFilms(string filmname)
        {
            ViewBag.currentfilm = filmname;
            using (var un = new UnitOfWork(new FilmsCollectionDBContext()))
            {
                un.FavouriteFilm.RemoveFromFavFilms(filmname);
                un.Complete();
            }
            return View();
        }
    }
}