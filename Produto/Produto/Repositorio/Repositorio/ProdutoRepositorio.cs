using Dominio;
using Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(BancoContexto bancoContexto) : base(bancoContexto)
        {

        }
    }
}
