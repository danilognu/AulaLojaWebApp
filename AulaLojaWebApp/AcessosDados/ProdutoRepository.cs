using AulaLojaWebApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaLojaWebApp.AcessosDados
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyWebAppContext _myWebAppContext;

        public ProdutoRepository(MyWebAppContext myWebAppContext)
        {
            _myWebAppContext = myWebAppContext;
        }

        public List<Produto> ListarProdutos()
        {
           return _myWebAppContext.Produtos.ToList();
        }

    }
}
