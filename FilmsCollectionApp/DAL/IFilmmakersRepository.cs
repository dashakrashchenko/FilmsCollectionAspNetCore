using System;
using System.Collections.Generic;
using System.Text;
using FilmsCollectionApp.Models;

namespace FilmsCollectionApp.DAL
{
    public interface IFilmmakersRepository: IRepository<Filmmakers>
    {
        Filmmakers GetInfoAboutFilmmaker(string firstname, string lastname);
        IEnumerable<Filmmakers> GetFilmmakerByGenre(string genre);
        IEnumerable<Filmmakers> GetFilmmakerbyAward(string award);
    }
}
