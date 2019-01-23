using System;
using System.Collections.Generic;

namespace FilmsCollectionApp.Models
{
    public partial class FavouriteFilm
    {
        public int? FilmId { get; set; }
        public int FavoriteFilmId { get; set; }

        public virtual Films Film { get; set; }
    }
}
