using System;
using System.Collections.Generic;
using System.Linq;

namespace desafio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UBUNTU 003 - STARS...\n");

            var ubuntu = new List<Ubuntu>();



            ubuntu.Add(new Ubuntu
            {
                Nome = "Ubuntu Silva",
                Idade = 33,
                Peso = 88.50,
                Altura = 1.60,
                EhDev = true
            });

            ubuntu.Add(new Ubuntu
            {
                Nome = "Ubuntu Santos",
                Idade = 26,
                Peso = 84.50,
                Altura = 2.10,
                EhDev = true
            });

            ubuntu.Add(new Ubuntu
            {
                Nome = "Ubuntu3 Silva",
                Idade = 85,
                Peso = 66.50,
                Altura = 1.40,
                EhDev = false
            });

            ubuntu.Add(new Ubuntu
            {
                Nome = "Ubuntu3 Santos",
                Idade = 70,
                Peso = 57.20,
                Altura = 1.80,
                EhDev = true
            });

            Console.WriteLine("Nossos ubuntus: \n");
            foreach (var devs in ubuntu)
            {

                Console.WriteLine(devs.Nome);
            }

            Dev ub = new Dev();
            ub.Contagem();

            GrupoRisco gr = new GrupoRisco();
            gr.Risco();

            //List<Ubuntu> Risco = ubuntu.FindAll(delegate (Ubuntu u) { return u.Idade > 50; });

            //Console.WriteLine("\nGrupo de risco: ");
            //Risco.ForEach(delegate (Ubuntu u)
            //{
            //    Console.WriteLine("{0} {1}", u.Idade, u.Nome);
            //});

            Bhaskara b = new Bhaskara();
            b.Formula();
        }
    }
}
