using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec_MVC_DEV.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public LivroRepository(BdDbContext context)
        {
            _context = context;
        }
        public async <IEnumerable<Livro>> BuscarLivrosAsync()
        {
            return await _contex.Livro
            .Include(l => l.LivroCategorias)
            .ThenInclude(ln => lc.Categoria)
            .ToListAsync();

        }
    }
}