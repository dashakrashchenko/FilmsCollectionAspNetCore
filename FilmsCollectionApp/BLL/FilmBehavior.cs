using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmsCollectionApp.Models;
using FilmsCollectionApp.DAL;

namespace FilmsCollectionApp.BLL
{
    public class FilmBehavior
    {
        private IFilmsRepository filmsrepo;
        private IFilmmakersRepository makerrepo;
        public FilmBehavior()
        {
            filmsrepo = new FilmsRepository(new FilmsCollectionDBContext());
            makerrepo = new FilmmakersRepository(new FilmsCollectionDBContext());
        }

        public Filmmakers GetDetailsAboutFilmmakerByFilm(Films film)
        {
            return makerrepo.GetAll()
                .Where(s => s.FilmMakerId == film.MakerId)                
                .First();
        }

    }
}
