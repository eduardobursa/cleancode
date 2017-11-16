using System.Collections.Generic;

namespace src.Dependencia
{
    public interface ITokenRepository
    {
        void Inserir(Token token);

        List<Token> ObterTodos();

        void DeletarToken(Token token);
    }
}