using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class BuscaViewModel
    {
        public Categoria Categoria { get; }
        public IList<Produto> Produtos { get; }

        public BuscaViewModel(Categoria categoria)
        {
            Categoria = categoria;
            Produtos = new List<Produto>();
        }
    }
}
