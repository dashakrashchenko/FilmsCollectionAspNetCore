using System;
using System.Collections.Generic;
using System.Text;

namespace FilmsCollectionApp.DAL
{
    public interface IUnitOfWork: IDisposable 
    {
        IFilmmakersRepository Filmmakers { get; }
        int Complete();
    }
}
