using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface IBaseRepositorio<Tentity> : IDisposable where Tentity : class 
    {
        void Adicionar(Tentity entity);

        Tentity ObterPorId(int id);
        IEnumerable<Tentity> ObterPorTodos();

        void Atualizar(Tentity entity);

        void Deletar(Tentity entity);
    }
}
