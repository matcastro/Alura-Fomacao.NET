using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class BuscaViewModel
    { 
        public string Pesquisa { get; set; }
        public IList<Produto> Produtos { get; }
        public BuscaViewModel(IList<Produto> produtos)
        {
            Produtos = produtos;
        }
    }
}
