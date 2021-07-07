using Dominio.Interfaces;
using Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio
{
    public class BaseRepositorio<Tentity> : IBaseRepositorio<Tentity> where Tentity : class
    {
        protected readonly BancoContexto BancoContexto;
        public BaseRepositorio(BancoContexto bancoContexto)
        {
            BancoContexto = bancoContexto;
        }
        public void Adicionar(Tentity item)
        {
            BancoContexto.Set<Tentity>().Add(item);
            BancoContexto.SaveChanges();
        }

        public void Atualizar(Tentity entity)
        {
            BancoContexto.Set<Tentity>().Update(entity);
            BancoContexto.SaveChanges();
        }

        public void Deletar(Tentity entity)
        {
            BancoContexto.Remove(entity);
            BancoContexto.SaveChanges();
        }

        public void Dispose()
        {
            BancoContexto.Dispose();
        }

        public Tentity ObterPorId(int id)
        {
            return BancoContexto.Set<Tentity>().Find(id);
        }
        public IEnumerable<Tentity> ObterPorTodos()
        {
            return BancoContexto.Set<Tentity>().ToList();

        }
    }
}
