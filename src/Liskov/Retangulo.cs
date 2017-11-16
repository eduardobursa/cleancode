using System.Diagnostics;

namespace src.Liskov
{
    class Retangulo
    {
        protected int largura;
        protected int altura;

        public virtual void SetLargura(int largura)
        {
            this.largura = largura;
        }

        public virtual void SetAltura(int altura)
        {
            this.altura = altura;
        }

        public int GetLargura()
        {
            return largura;
        }

        public int GetAltura()
        {
            return altura;
        }

        public int GetArea()
        {
            return largura * altura;
        }
    }

    class Quadrado : Retangulo
    {
        public override void SetLargura(int largura)
        {
            base.largura = largura;
            altura = largura;
        }

        public override void SetAltura(int altura)
        {
            largura = altura;
            base.altura = altura;
        }
    }

    public class FormaService
    {
        private static Retangulo NewRetangulo()
        {
            // uma factory
            return new Quadrado();
        }

        public void ProcessarArea()
        {
            //vamos criar um novo retangulo
            Retangulo retangulo = FormaService.NewRetangulo();

            //definindo a largura e altura do retangulo   
            retangulo.SetLargura(5);
            retangulo.SetAltura(10);

            // o usuário sabe que r é um retângulo
            // e assume que ele pode definir largura e altura
            // como para a classe base(Retangulo)

            Debug.WriteLine(retangulo.GetArea());

            // O valor retornado é 100 e não 50 como era esperado
        }
    }
}