using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface ICategoriaRepository
    {
        Task<Categoria> SaveCategoria(string nome);
    }
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public async Task<Categoria> SaveCategoria(string nome)
        {
            Categoria categoria = dbSet.Where(c => c.Nome.Equals(nome)).FirstOrDefault();
            if (categoria == null)
            {
                categoria = dbSet.Add(new Categoria(nome)).Entity;
                await contexto.SaveChangesAsync();
            }
            return categoria;
        }
    }
}
