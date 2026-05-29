using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec_MVC_DEV.Interfaces
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> BuscarLivroAsync();
    }
}