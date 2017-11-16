using System;
using System.Collections.Generic;

namespace src.Segregacao
{
    public class CidadeRepository : IBaseRepository<Cidade>
    {
        public void Gravar(Cidade obj)
        {
            throw new Exception("Não existe operação de gravação para Cidade");
        }

        public void Atualizar(Cidade obj)
        {
            throw new Exception("Não existe operação de atualização para Cidade");
        }

        public IEnumerable<Cidade> ObterTodos()
        {
            return new List<Cidade>();
        }

        public Cidade ObterPorId(int id)
        {
            return new Cidade();
        }
    }
}