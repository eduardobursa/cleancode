using System.Collections.Generic;
using System.Diagnostics;

namespace src.AbertoFechado
{
    public class Editor
    {
        public void DesenharFormas(List<Forma> formas)
        {
            foreach (var forma in formas)
            {
                if (forma is Quadrado)
                {
                    DesenharQuadrado();
                }
                else if (forma is Circulo)
                {
                    DesenharCirculo();
                }
            }
        }

        public void DesenharCirculo()
        {
            Debug.WriteLine("Desenhando circulo");
        }

        public void DesenharQuadrado()
        {
            Debug.WriteLine("Desenhando quadrado");
        }
    }

    public class Forma
    {
        public int Valor { get; set; }
    }

    public class Quadrado : Forma
    {
        Quadrado()
        {
        }
    }

    public class Circulo : Forma
    {
        Circulo()
        {
        }
    }
}