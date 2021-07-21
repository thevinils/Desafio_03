using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace desafio_3
{
    class GrupoRisco
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Risco()
        {
            int risco = 50;

            GrupoRisco[] ubuntus =
           {
                new GrupoRisco {Nome = "Ubuntu Silva", Idade = 33  },
                new GrupoRisco {Nome = "Ubuntu Silva", Idade = 26},
                new GrupoRisco {Nome = "Ubuntu Silva", Idade = 85 },
                new GrupoRisco {Nome = "Ubuntu Silva", Idade = 70}

            };

            try
            {
                int Idade = ubuntus.Count(u => u.Idade > risco);
                Console.WriteLine("{0} ubuntus devs ficar em casa. \n", Idade);
            }
            catch (OverflowException)
            {
                return;
            }

        }
    }
}
