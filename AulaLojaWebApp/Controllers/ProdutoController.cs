using AulaLojaWebApp.AcessosDados;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AulaLojaWebApp.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {

        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public string Get()
        {
            return "TEste";
        }

    }
}
