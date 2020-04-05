using System;
using System.Collections.Generic;

/*
 No portal de cursos online Udemy, cada usuário possui um código único, representado por um número inteiro.
Cada instrutor do portal Udemy pode ter vários cursos, sendo que um mesmo aluno pode se matricular em quantos
cursos quiser. Assim, o número total de alunos de um instrutor não é simplesmente a soma dos alunos de todos os
cursos que ele possui, pois pode haver alunos repetidos em mais de um curso.
O instrutor Joaquim possui três cursos A, B e C, e deseja saber seu número total de alunos.
Seu programa deve ler os alunos dos cursos A, B e C do instrutor Joaquim, depois mostrar a quantidade total e alunos
dele, conforme exemplo.

O curso A possui quantos alunos? 3
Digite os códigos dos alunos do curso A:
21
35
22
O curso B possui quantos alunos? 2
Digite os códigos dos alunos do curso B:
21
50
O curso C possui quantos alunos? 3
Digite os códigos dos alunos do curso C:
42
35
13
Total de alunos: 6
*/

namespace Exercicio83
{
    class Program
    {
        static void Main()
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int numA = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            for (int i = 0; i < numA; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                cursoA.Add(cod);
            }

            Console.Write("O curso B possui quantos alunos? ");
            int numB = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            for (int i = 0; i < numB; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                cursoB.Add(cod);
            }

            Console.Write("O curso C possui quantos alunos? ");
            int numC = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            for (int i = 0; i < numC; i++)
            {
                int cod = int.Parse(Console.ReadLine());
                cursoC.Add(cod);
            }

            cursoA.UnionWith(cursoB);
            cursoA.UnionWith(cursoC);

            Console.WriteLine("Total de alunos: " + cursoA.Count);

        }
    }
}
