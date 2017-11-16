using System.Collections.Generic;
using System.Diagnostics;

namespace src.AbertoFechado
{
    public class EditorCC
    {
        public void DesenharFormas(List<FormaCC> formas)
        {
            foreach (var forma in formas)
            {
                forma.Desenhar();
            }
        }

        public abstract class FormaCC
        {
            public int Valor { get; set; }
            public abstract void Desenhar();
        }

        public class QuadradoCC : FormaCC
        {
            QuadradoCC()
            {
            }

            public override void Desenhar()
            {
                Debug.WriteLine("Desenhando Quadrado");
            }
        }

        public class CirculoCC : FormaCC
        {
            CirculoCC()
            {
            }

            public override void Desenhar()
            {
                Debug.WriteLine("Desenhando Circulo");
            }
        }
    }
}