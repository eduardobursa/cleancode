using System.Collections.Generic;

namespace src.Segregacao
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Gravar(TEntity obj);
        void Atualizar(TEntity obj);
        IEnumerable<TEntity> ObterTodos();
        TEntity ObterPorId(int id);
    }
}