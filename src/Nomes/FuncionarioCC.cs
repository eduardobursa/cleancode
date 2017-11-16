using System;
using System.Collections.Generic;

namespace src.Nomes
{
    public class FuncionarioCC
    {
        public int DiaPagamento { get; set; }

		public Decimal Salario { get; set; }

		public List<int> ObtemDiasFolga()
		{
			 List<int> mes = new List<int>(); 
			 List<int> diasFolga = new List<int>(); 
			 
			 foreach (int dia in mes) 
			 { 
				 if (dia % 2 == 0) 
				 { 
					 diasFolga.Add(dia); 
				 } 
			 } 
			 
			 return diasFolga; 
		}

		public void ImportarDaDosDeDependentes()
		{
			// importa os dados de dependentes
		}
    }
}