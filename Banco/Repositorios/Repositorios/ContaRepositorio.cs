using Dominio.Entidades;
using Dominio.Interfaces;
using Repositorios.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorios.Repositorios
{
    public class ContaRepositorio : BaseRepositorio<Conta>, IContaRepositorio
    {
        public ContaRepositorio(BancoContexto bancoContexto) : base(bancoContexto)
        {

        }
    }
}
