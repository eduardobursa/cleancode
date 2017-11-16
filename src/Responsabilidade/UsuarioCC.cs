using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace src.Responsabilidade
{
    public class UsuarioCC
    {
        public UsuarioCC(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Ativo = false;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public bool Ativo { get; private set; }

        public void Atualizar(string nome)
        {
            Nome = nome;
        }

        public void AtivarUsuario()
        {
            Ativo = true;
        }

        public void RedefinirSenha()
        {
            Senha = "NovaSenha*123";
        }

    }
}