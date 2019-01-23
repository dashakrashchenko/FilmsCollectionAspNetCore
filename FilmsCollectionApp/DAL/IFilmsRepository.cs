using System;
using System.Collections.Generic;
using System.Text;
using FilmsCollectionApp.Models;

namespace FilmsCollectionApp.DAL
{
    interface IFilmsRepository: IRepository<Films>
    {
        IEnumerable<Films> GetAllFilmsByFilmmaker(string firstname, string lastname);
        Films GetInfoAboutFilm(string filmname);
        IEnumerable<Films> GetAllFilmsByGenre(string genre);
        IEnumerable<Films> GetAllFilmsByReleaseDate(DateTime date);
        IEnumerable<Films> GetSortedByImdb();
    }
}
