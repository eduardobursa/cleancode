namespace src.Responsabilidade
{
    public class UsuarioService
    {
        IUsuarioRepository _repo = new UsuarioRepository();

        public void InserirNovoUsuario()
        {
            UsuarioCC novoUsuario = new UsuarioCC("Joao", "joao@cwi.com.br", "mudar*123");
            novoUsuario.AtivarUsuario();

            _repo.Inserir(novoUsuario);

            /*fora da entidade Usuario, alteramos a senha e enviamos o e-mail*/
            Mail.Enviar("Seu usuário foi criado");
        }
    }
}