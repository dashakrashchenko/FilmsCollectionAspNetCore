using System;
using System.Collections.Generic;
using System.Text;
using FilmsCollectionApp.Models;

namespace FilmsCollectionApp.DAL
{
    interface IFavouriteFilmRepository:IRepository<FavouriteFilm>
    {
        void AddToFavFilms(string filmname);
        void RemoveFromFavFilms(string filmname);
    }
}
