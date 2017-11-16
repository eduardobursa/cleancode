using System.Collections.Generic;

namespace src.Segregacao
{
    public class CidadeRepositoryCC : IBaseLeituraRepository<Cidade>
    {
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