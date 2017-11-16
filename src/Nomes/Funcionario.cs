using System;
using System.Collections.Generic;

namespace src.Nomes
{
    public class Func // funcionário da empresa
    {
        public int D { get; set; } // Dia de pagamento.

        public Decimal S { get; set; } // Salário 

        public List<int> Obtem()
		{
			 List<int> m = new List<int>(); // mes
			 List<int> df = new List<int>(); // dias de folga
			 
			 foreach (int d in m) 
			 { 
				 if (d % 2 == 0) 
				 { 
					 df.Add(d); 
				 } 
			 } 
			 
			 return df; 
		}

		public void ImpDaDep() 
		{
			// importa os dados de dependentes
		}
    }
}