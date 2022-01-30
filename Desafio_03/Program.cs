using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio_03
{
    class Program
    {
        static void Main(string[] args)
        {

            


            List <int> quantidalunos = new List<int>();
            List <string> nomealunos = new List<string>();
            List <int> notalunos = new List<int>();



            

            /// QUANTIDADE ALUNOS ATÉ 3
            

            Console.WriteLine("(Aperte enter para começar, o sistema armazenará as notas e os nomes de 3 alunos)");

            Console.ReadLine();

            Console.WriteLine("Quantos alunos são?");

            List<string> quantidalunos2 = quantidalunos.ConvertAll<string>(delegate (int i) { return i.ToString(); });

            quantidalunos2.Add(Console.ReadLine());

            Console.WriteLine("você incluirá..." +quantidalunos2[0]+"...alunos no sistema, aperte enter para continuar...");
            
            Console.ReadLine();

            
            /// ALUNO 1


            Console.WriteLine("Escreva o nome do aluno, em seguida aperte enter e insira a nota do aluno");

            nomealunos.Add(Console.ReadLine());


            Console.WriteLine("insira a nota do aluno");

            List<string> notalunos2 = notalunos.ConvertAll<string>(delegate (int i) { return i.ToString(); });

            notalunos2.Add(Console.ReadLine());


           
            
            Console.WriteLine("O aluno:..." + nomealunos[0] + "...Obteve a nota..." + notalunos2[0]);
           
            


            
            
            Console.WriteLine("Aperte enter para incluir mais um aluno");

            Console.ReadLine();


            /// ALUNO 2




            Console.WriteLine("Escreva o nome do aluno, em seguida aperte enter e insira a nota do aluno");

            nomealunos.Add(Console.ReadLine());


            Console.WriteLine("insira a nota do aluno");

            notalunos2.Add(Console.ReadLine());

            Console.WriteLine("O aluno:..." + nomealunos[1] + "...Obteve a nota..." + notalunos2[1]);


            Console.WriteLine("Aperte enter para incluir mais um aluno");

            Console.ReadLine();


            /// ALUNO 3 




            Console.WriteLine("Escreva o nome do aluno, em seguida aperte enter e insira a nota do aluno");

            nomealunos.Add(Console.ReadLine());


            Console.WriteLine("insira a nota do aluno");

            notalunos2.Add(Console.ReadLine());

            Console.WriteLine("O aluno:..." + nomealunos[2] + "...Obteve a nota..." + notalunos2[2]);

            Console.WriteLine();

            Console.WriteLine("Aperte enter para mostrar os alunos incluídos");


            Console.ReadLine();

            ///// FOREACH


            foreach (string nome in nomealunos)
            {
                Console.WriteLine(nome);

            }

            Console.WriteLine();

            Console.WriteLine("Aperte enter para mostrar o aluno com a maior nota");

            Console.ReadLine();

            //////// MAIOR NOTA



            var listaConcatenada = notalunos2.Concat(nomealunos);

            string maiornota = listaConcatenada.Max();

            Console.WriteLine("O aluno..." + maiornota + "...Obteve a maior nota da lista atual.");

            Console.WriteLine();

            Console.WriteLine("aperte ENTER para sair");


            
            







            Console.ReadKey();




            ; ; ;

        }
    }
}
