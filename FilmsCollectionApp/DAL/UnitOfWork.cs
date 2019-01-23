using System;
using System.Collections.Generic;
using System.Text;
using FilmsCollectionApp.Models;

namespace FilmsCollectionApp.DAL
{
    class UnitOfWork:IUnitOfWork
    {
        private readonly FilmsCollectionDBContext _context;

        public UnitOfWork(FilmsCollectionDBContext context)
        {
            _context = context;
            Filmmakers = new FilmmakersRepository(_context);
            Films = new FilmsRepository(_context);
            FavouriteFilm = new FavouriteFilmRepository(_context);
        }
        public IFilmmakersRepository Filmmakers { get; private set; }
        public IFilmsRepository Films { get; private set; }
        public  IFavouriteFilmRepository FavouriteFilm { get;  set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
