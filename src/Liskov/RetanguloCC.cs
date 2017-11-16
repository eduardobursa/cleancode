using System.Diagnostics;

namespace src.Liskov
{
    public abstract class ShapeCC
    {
        public abstract int GetArea();
    }

    class RetanguloCC : ShapeCC
    {
        int largura;
        int altura;

        public virtual void SetLargura(int largura)
        {
            this.largura = largura;
        }

        public virtual void SetAltura(int altura)
        {
            this.altura = altura;
        }
        public override int GetArea()
        {
            return largura * altura;
        }
    }

    class QuadradoCC : ShapeCC
    {
        int lado;

        public void SetLado(int lado)
        {
            this.lado = lado;
        }

        public override int GetArea()
        {
            return lado * lado;
        }
    }

    public class FormaServiceCC
    {
        private static RetanguloCC NewRetangulo()
        {
            // uma factory
            return new RetanguloCC();
        }

        public void ProcessarArea()
        {
            //vamos criar um novo retangulo
            var retangulo = FormaServiceCC.NewRetangulo();

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