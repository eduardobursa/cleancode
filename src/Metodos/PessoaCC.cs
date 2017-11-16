namespace src.Metodos
{
    public class PessoaCC
    {
        public string Cpf { get; set; }
        public string RG { get; set; }
        public string Cnh { get; set; }

        public bool ValidarDados() // valida os dados da pessoa
        {
            return ValidarCnh() && ValidarRG() && ValidarCpf();
        }

        private bool ValidarCnh() // o método separado com uma responsabilidade única é mais fácil de reaproveitar
        {
            return true;
        }

        private bool ValidarRG()
        {
            return true;
        }

        private bool ValidarCpf()
        {
            return true;
        }
    }
}