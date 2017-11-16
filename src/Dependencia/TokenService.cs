namespace src.Dependencia
{
    public class TokenService
    {
        TokenRepository repositorio = new TokenRepository();

        public void InserirNovoToken()
        {
            Token novoToken = new Token("1234-1234-1234-1234");
            novoToken.Ativar();

            repositorio.Inserir(novoToken);
        }
    }
}