namespace src.Comentarios
{
    public class Empregado
    {
        public int Idade { get; set; }
        public int TempoDeContribuicao { get; set; }
    }

    public class EmpregadoService
    {
        public void AplicarAposentadoria(Empregado empregado)
        {
            // verifica se o empregado possui as condições necessárias para aposentadoria
            if (empregado.Idade >= 65 && empregado.TempoDeContribuicao >= 50)
			{
				/* */
			}
        }
    }
}