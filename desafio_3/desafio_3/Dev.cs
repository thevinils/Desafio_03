using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace desafio_3
{
    class Dev
    {
        public string nome { get; set; }
        public bool EhDev { get; set; }

        public void Contagem()
        {
            Dev[] ubuntus =
            {
                new Dev {nome = "Ubuntu Silva", EhDev=true },
                new Dev {nome = "Ubuntu Silva", EhDev=true },
                new Dev {nome = "Ubuntu Silva", EhDev=false },
                new Dev {nome = "Ubuntu Silva", EhDev=true }

            };

            try
            {
                int EhDev = ubuntus.Count(u => u.EhDev == true);
                Console.WriteLine("\n{0} ubuntus são devs. \n", EhDev);
            }
            catch (OverflowException)
            {
                return;
            }



        }
    }
}
