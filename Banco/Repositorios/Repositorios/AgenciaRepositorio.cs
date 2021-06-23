using Dominio.Entidades;
using Dominio.Interfaces;
using Repositorios.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorios.Repositorios
{
    public class AgenciaRepositorio : BaseRepositorio <Agencia>, IAgenciaRepositorio
    {
        public AgenciaRepositorio(BancoContexto bancoContexto) : base(bancoContexto)
        {

        }
    }
}
