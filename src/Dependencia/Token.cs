using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace src.Dependencia
{
    public class Token
    {
		bool ativo;
        string token;

        public Token(string token)
        {
            this.token = token;
        }

        public void Ativar()
        {
            ativo = true;
        }
    }
}