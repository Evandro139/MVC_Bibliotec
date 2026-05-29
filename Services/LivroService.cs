using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bibliotec_MVC_DEV.Services
{
    public class LivroService : ILivroService
     {
        private readonly ILivroRepository _livroRepository;

        public LivroService(ILivroRepository livroRepository)
        {
            _LivroRepository = LivroRepository;
        }
        
        public Task<IEnumerable<Livro>> BuscarLivrosComCatAsync()
        {
            return await _livroRepository.BuscarLivrosAsync();
        }
    }
}