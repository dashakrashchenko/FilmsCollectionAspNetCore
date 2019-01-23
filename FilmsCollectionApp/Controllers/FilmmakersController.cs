using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FilmsCollectionApp.Models;
using FilmsCollectionApp.DAL;


namespace FilmsCollectionApp.Controllers
{
    public class FilmmakersController : Controller
    {
        private IFilmmakersRepository makerrepo;
        private IFilmsRepository filmsrepo;
        public FilmmakersController()
        {
            makerrepo = new FilmmakersRepository(new FilmsCollectionDBContext());
            filmsrepo = new FilmsRepository(new FilmsCollectionDBContext());
        }

        public ViewResult FilmmakerInfo(string firstname, string lastname)
        {
            Filmmakers filmmaker = makerrepo.GetInfoAboutFilmmaker(firstname, lastname);
            ViewBag.FilmsByFilmmaker = filmsrepo.GetAllFilmsByFilmmaker(firstname, lastname);
            return View(filmmaker);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string firstName, string lastName)
        {
            RedirectToAction("FilmmakerInfo", "Filmmakers", new { firstname = firstName});
            return View();
        }

        public ViewResult FilmmakersbyGenre(string genre)
        {
            ViewBag.FilmmakersbyGenre = makerrepo.GetFilmmakerByGenre(genre).Take(5);
            return View();
        }

        public ViewResult FilmmakersbyAwars(string award)
        {
            ViewBag.FilmmakersbyGenre = makerrepo.GetFilmmakerbyAward(award).Take(5);
            return View();
        }
    }
}