using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace src.Responsabilidade
{
    public class Usuario
    {
        List<Usuario> database = new List<Usuario>();

        public Usuario(string nome, string email, string senha)
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

        public void Inserir(Usuario usuario)
        {
            database.Add(usuario);
        }

        public List<Usuario> ObterTodos()
        {
            return database.ToList();
        }

        public void DeletarUsuario(Usuario usuario)
        {
            database.Remove(usuario);
        }

        public void RedefinirSenha()
        {
            string novaSenha = "NovaSenha*123";
            MandarEmailRedefinicaoSenha(novaSenha);
        }

        public void MandarEmailRedefinicaoSenha(string novaSenha)
        {
            try
            {
				// vai  gerar um forte acoplamento com o envio de e-mail
                Debug.WriteLine("email");
            }
            catch (System.Exception)
            {
                throw;
            }

        }
    }
}