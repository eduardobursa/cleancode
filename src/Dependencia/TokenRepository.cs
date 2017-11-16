using System.Collections.Generic;
using System.Linq;

namespace src.Dependencia
{
    public class TokenRepository : ITokenRepository
    {
        List<Token> database = new List<Token>();

        public void Inserir(Token token)
        {
            database.Add(token);
        }

        public List<Token> ObterTodos()
        {
            return database.FindAll(t => true);
        }

        public void DeletarToken(Token token)
        {
            database.Remove(token);
        }
    }
}