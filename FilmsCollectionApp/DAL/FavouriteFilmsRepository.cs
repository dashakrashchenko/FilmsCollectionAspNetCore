using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FilmsCollectionApp.Models;
using Microsoft.EntityFrameworkCore;


namespace FilmsCollectionApp.DAL
{
    class FavouriteFilmRepository:Repository<FavouriteFilm>,IFavouriteFilmRepository
    {
        public FavouriteFilmRepository(FilmsCollectionDBContext cont)
           :base(cont)
        { }

        public void AddToFavFilms(string filmname)
        {
            try
            {
                var newfilm = FilmsCollectionDb.Films.Where(t => t.Filmname == filmname).FirstOrDefault();
                FavouriteFilm favfilms = new FavouriteFilm();
                favfilms.Film = newfilm;
                favfilms.FilmId = newfilm.FilmId;
                FilmsCollectionDb.FavouriteFilm.Add(favfilms);
            }
            catch(Exception)
            {
                throw new Exception("Film not found");
            }
          
            
        }

        public void RemoveFromFavFilms(string filmname)
        {
            try
            {
                var olditem = FilmsCollectionDb.Films.Where(t => t.Filmname == filmname).FirstOrDefault();
                var a = FilmsCollectionDb.FavouriteFilm.Where(t => t.Film == olditem).FirstOrDefault();
                FilmsCollectionDb.FavouriteFilm.Remove(a);
            }
            catch(Exception)
            {
                throw new Exception("Film not found");
            }
        }

        private FilmsCollectionDBContext FilmsCollectionDb
        {
            get { return context as FilmsCollectionDBContext; }
        }
    }
}
