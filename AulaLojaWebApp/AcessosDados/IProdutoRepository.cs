using System.Collections.Generic;
using AulaLojaWebApp.Entidades;

namespace AulaLojaWebApp.AcessosDados
{
    public interface IProdutoRepository
    {
        List<Produto> ListarProdutos();
    }
}