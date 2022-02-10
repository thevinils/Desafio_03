using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_03
{
    class Program
    {
        static void Main(string[] args)
        {

            


            int quantidalunos = 0;
            
            List <string> nomealunos = new List<string>();
            List <int> notalunos = new List<int>();






            

            /// QUANTIDADE ALUNOS
            

            

            Console.WriteLine("Bem vindo, o sistema armazenará 3 alunos por vez, aperte enter para continuar");

            Console.WriteLine();

            Console.ReadLine();

            Console.WriteLine("Quantos alunos serão incluídos no sistema? '1 até 3' ");





            string quantidalunosst;
            
            quantidalunosst = quantidalunos.ToString();


            quantidalunosst = Console.ReadLine();

            Console.WriteLine("você incluirá..." + quantidalunosst +"...alunos no sistema, aperte enter para inserir nome e nota do aluno...");
            
            Console.ReadLine();

            Console.WriteLine();


            /// ALUNOS E NOTAS 


            


            for (quantidalunos = 0; quantidalunos < 3; quantidalunos++)


            {

                Console.WriteLine("Digite um nome para inserir na lista:");
                string nome = Console.ReadLine();
                nomealunos.Add(nome);

                Console.WriteLine("Digite uma nota para inserir na lista:");

                string notast;
                int nota = 0;
                notast = nota.ToString();

                
                notast = Console.ReadLine();
                nomealunos.Add(notast);

                Console.WriteLine("APERTE ENTER PARA INSERIR O PRÓXIMO ALUNO");

                Console.WriteLine();

                Console.ReadLine();



            }

            Console.WriteLine("ALUNOS INSERIDOS, APERTE ENTER PARA VIZUALIZAR O ALUNO COM A MAIOR NOTA");

            Console.WriteLine();

            Console.ReadLine();


            //////// MAIOR NOTA


            List<string> notalunosst = notalunos.ConvertAll<string>(delegate (int i) { return i.ToString(); });

            List<string> listaconcatenada = nomealunos.Concat(notalunosst).ToList();

            string maiornota = listaconcatenada.Max();

            Console.WriteLine("O aluno..." + maiornota + "...Obteve a maior nota da lista atual.");

            Console.WriteLine();

            Console.WriteLine("aperte ENTER para sair");


            
            







            Console.ReadKey();




            ; ; ;

        }
    }
}
