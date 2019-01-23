using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FilmsCollectionApp.Models;
using FilmsCollectionApp.DAL;
using FilmsCollectionApp.BLL;

namespace FilmsCollectionApp.Controllers
{
    public class FilmsController : Controller
    {
        private IFilmsRepository filmsrepo;
        private IFilmmakersRepository makerrepo;
        private FilmBehavior filmBehavior;
        public FilmsController()
        {
            filmsrepo = new FilmsRepository(new FilmsCollectionDBContext());
            makerrepo = new FilmmakersRepository(new FilmsCollectionDBContext());
            filmBehavior = new FilmBehavior();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.FilmsByImdb = filmsrepo.GetSortedByImdb().Take(10);
            ViewBag.NewFilms = filmsrepo.GetAll().OrderByDescending(d => d.Releasedate).Take(10);
            return View();
        }

        [HttpPost]
        public IActionResult Index(string searchInput, string searchChoice)
        {
            if (searchChoice == "filmname")
                return RedirectToAction("FilmInfo", "Films", new { filmname = searchInput });
            else return RedirectToAction("FilmsByGenre", "Films", new { genre = searchInput });
        }

        public ViewResult FilmInfo(string filmname)
        {
            Films film = filmsrepo.GetInfoAboutFilm(filmname);
            Filmmakers maker = filmBehavior.GetDetailsAboutFilmmakerByFilm(film);
            ViewBag.FilmMaker = maker;
            ViewBag.FilmsByThisFilmmaker = filmsrepo.GetAllFilmsByFilmmaker(maker.Firstname, maker.Lastname);
            return View(film);
        }

        public ViewResult FilmsByGenre(string genre)
        {
            ViewBag.FilmsByGenre = filmsrepo.GetAllFilmsByGenre(genre);
            return View();
        }

    }
}