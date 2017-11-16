using System.Collections.Generic;
using System.Linq;

namespace src.Responsabilidade
{
    public class UsuarioRepository : IUsuarioRepository
    {
        List<UsuarioCC> database = new List<UsuarioCC>();

        public void Inserir(UsuarioCC usuario)
        {
            database.Add(usuario);
        }

        public List<UsuarioCC> ObterTodos()
        {
            return database.FindAll(t => true);
        }

        public void DeletarUsuario(UsuarioCC usuario)
        {
            database.Remove(usuario);
        }
    }
}