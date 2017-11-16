using System.Diagnostics;

namespace src.Responsabilidade
{

	// INFRAESTRUTUA  
    public static class Mail
    {
        public static void Enviar(string mensagem)
        {
            try
            {
                Debug.WriteLine(mensagem);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}