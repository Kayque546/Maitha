using Dominio.Entidades;
using Dominio.Interfaces;
using Repositorios.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorios.Repositorios
{
    public class ClienteRepositorio : BaseRepositorio <Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(BancoContexto bancoContexto) : base(bancoContexto)
        {

        }
    }
}
