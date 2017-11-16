using System.Collections.Generic;

namespace src.Responsabilidade
{
    public interface IUsuarioRepository
    {
        void Inserir(UsuarioCC usuario);
        List<UsuarioCC> ObterTodos();
        void DeletarUsuario(UsuarioCC usuario);
    }
}