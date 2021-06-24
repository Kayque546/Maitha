﻿using Dominio.Interfaces;
using Repositorios.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorios.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly BancoContexto BancoContexto;

        public BaseRepositorio(BancoContexto bancoContexto)
        {
            BancoContexto = bancoContexto;
        }

        public TEntity ObterPorId(int id)
        {
            return BancoContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos() 
        {
            return BancoContexto.Set<TEntity>().ToList();
        }


        public void Adicionar(TEntity entity)
        {
            BancoContexto.Set<TEntity>().Add(entity);
            BancoContexto.SaveChangesAsync();
        }

        public void Atualizar (TEntity entity)
        {
            BancoContexto.Set<TEntity>().Update(entity);
            BancoContexto.SaveChangesAsync();
        }

        public void Remover(TEntity entity)
        {
            BancoContexto.Remove(entity);
            BancoContexto.SaveChangesAsync();
        }

        public void Dispose () 
        { 
            BancoContexto.Dispose(); 
        }

        public IEnumerable<TEntity> obterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
