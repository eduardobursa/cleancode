namespace src.Comentarios
{
    public class EmpregadoCC
    {
		private const int IdadeMinimaParaAposentadoria = 65;
		private const int PeridoMinimoContribuicaoParaAposentadoria = 50;

        public int Idade { get; set; }
        public int TempoDeContribuicao { get; set; }

		/// <summary>
		///  A partir de 2017, a aposentadoria requer além do tempo mínimo de 
		///  contribuição que o empregado possua também uma idade mínima.
		///  REF: Lei Nº 12345.5 
		/// </summary>
		public bool AptoParaAposentadoria 
		{ 
			get
			{
				return 
					Idade >= IdadeMinimaParaAposentadoria 
					&& 
					TempoDeContribuicao >= PeridoMinimoContribuicaoParaAposentadoria;
			}
		}

		public bool ValidarAptidaoAposentadoria()
        {
            return 
				Idade >= IdadeMinimaParaAposentadoria 
				&& 
				TempoDeContribuicao >= PeridoMinimoContribuicaoParaAposentadoria;
        }
    }

    public class EmpregadoServiceCC
    {
        public void AplicarAposentadoria(EmpregadoCC empregado)
        {
            if (empregado.AptoParaAposentadoria)
			{
				/* */
			}

			// ou 

			if (empregado.ValidarAptidaoAposentadoria())
			{
				/* */
			}
        }
    }
}