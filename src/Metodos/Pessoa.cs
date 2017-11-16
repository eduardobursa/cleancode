namespace src.Metodos
{
    public class Pessoa
    {
        public string Cpf { get; set; }
        public string RG { get; set; }
        public string Cnh { get; set; }

        public bool Valida() // valida os dados da pessoa
        {
            if (!string.IsNullOrEmpty(Cnh))
            {
                // lógica referentes a validação da CNH
                // ...
            }

            if (!string.IsNullOrEmpty(RG))
            {
                // lógica referentes a validação do RG
                // ...
            }

            if (!string.IsNullOrEmpty(Cpf))
            {
                // lógica referentes a validação do CPF
                // ...
            }

            return false;
        }


    }
}