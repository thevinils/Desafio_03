using System;
using System.Collections.Generic;

namespace Desafio_03
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public double nota;

        public Aluno(string nome, int idade, double nota)
        {
            this.nome = nome;
            this.idade = idade;
            this.nota = nota;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string nomeMaiorNota = null;
            string nomeMaiorNota2 = null;
            int idadeMaiorNota = 0;
            int idadeMaiorNota2 = 0;
            double maiorNota = 0;


            Console.WriteLine("Quantos alunos há na turma?");
            int n = Convert.ToInt32(Console.ReadLine());
            int numAlunos = n;

            Aluno[] alunos = new Aluno[numAlunos];

            for(int i = 0; i < numAlunos; i++)
            {
                int count = i+1;

                Console.WriteLine("Qual o nome do aluno {0}?", count);
                string nome = Console.ReadLine();

                Console.WriteLine("Qual a idade do {0}?", nome);
                int idade = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual a nota do {0}?", nome);
                double nota = Convert.ToDouble(Console.ReadLine());

                alunos[i] = new Aluno(nome, idade, nota);
            }
            for (int i = 0; i < numAlunos; i++)
            {
                if(maiorNota < alunos[i].nota)
                {
                    nomeMaiorNota = alunos[i].nome;
                    idadeMaiorNota = alunos[i].idade;
                    maiorNota = alunos[i].nota;
                } else if (maiorNota == alunos[i].nota)
                {
                    nomeMaiorNota2 = alunos[i].nome;
                    idadeMaiorNota2 = alunos[i].idade;
                }
            }
            if(nomeMaiorNota2 == null)
            {
                Console.WriteLine("Nome do aluno com a maior nota:" + nomeMaiorNota + "\nIdade do aluno: " + idadeMaiorNota + "\nNota do aluno: " + maiorNota);
            } 
            else
            {
                Console.WriteLine("Nome dos alunos com as maiores notas:" + nomeMaiorNota + " e " + nomeMaiorNota2 + "\nIdade dos alunos: " + idadeMaiorNota + " e " + idadeMaiorNota2 + "\nNota dos alunos: " + maiorNota);
            }


        }
    }
}
