namespace src.Dependencia
{
    public class TokenServiceCC
    {
        ITokenRepository repositorio;

		public TokenServiceCC(ITokenRepository repositorio)
		{
			this.repositorio = repositorio;
		}

        public void InserirNovoToken()
        {
            Token novoToken = new Token("1234-1234-1234-1234");
            novoToken.Ativar();

            repositorio.Inserir(novoToken);
        }
    }
}