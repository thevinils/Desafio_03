using System;
using System.Collections.Generic;
using System.Text;

namespace desafio_3
{
    class Bhaskara :GrupoRisco
    {
        public void Formula()
        {
            int a = 33, b = 26, c = 70;
            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);



            double x1 = ((-b) + raiz) / (2 * a);
            double x2 = ((-b) - raiz) / (2 * a);

            if (delta < 0)
            {
                Console.WriteLine("Essa função não possui raízes reais.");

            }

            Console.WriteLine("x1 é " + x1);
            Console.WriteLine("x2 é " + x2);
        }

    }
}
