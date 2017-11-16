using System.Collections.Generic;

namespace src.Segregacao
{
    public class ClienteRepositoryCC : IBaseEscritaRepository<Cliente>, IBaseLeituraRepository<Cliente>
    {
        public void Gravar(Cliente obj)
        {
            // lógica de gravar
        }

        public void Atualizar(Cliente obj)
        {
            // lógica de atualizar
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            // lógica de listar todos
			return new List<Cliente>();
        }

        public Cliente ObterPorId(int id)
        {
            // lógica de buscar por id

			return new Cliente();
        }
    }
}