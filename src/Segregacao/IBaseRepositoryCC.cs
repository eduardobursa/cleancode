using System.Collections.Generic;

namespace src.Segregacao
{
    public interface IBaseEscritaRepository<TEntity> where TEntity : class
    {
        void Gravar(TEntity obj);
        void Atualizar(TEntity obj);
    }

    public interface IBaseLeituraRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
    }
}