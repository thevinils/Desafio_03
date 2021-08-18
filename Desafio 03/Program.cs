using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace LuanDesafio03
{
    class Program   
    {
        static void Main(string[] args)
        {            

            Console.WriteLine("Digite a Quantidade de Alunos:");
            int Quantidade = int.Parse(Console.ReadLine());                      
            Console.WriteLine("Qual o Nome do Aluno?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a Nota do aluno?");
            int nota = int.Parse(Console.ReadLine());
            Console.WriteLine("Aluno com maior avaliação:");
            Console.WriteLine(nome);
            

           
        }


        }

            
    }

