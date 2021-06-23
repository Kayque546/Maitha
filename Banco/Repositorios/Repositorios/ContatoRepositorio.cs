using Dominio.Entidades;
using Dominio.Interfaces;
using Repositorios.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorios.Repositorios
{
    public class ContatoRepositorio : BaseRepositorio<Contato>, IContatoRepositorio
    {
        public ContatoRepositorio(BancoContexto bancoContexto) : base(bancoContexto) 
        {
        
        }
    }
}
