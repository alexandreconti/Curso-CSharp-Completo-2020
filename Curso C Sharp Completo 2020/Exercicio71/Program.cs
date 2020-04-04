using System;

/*
A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto,
conforme exemplo.

Quantos quartos serão alugados? 3
Aluguel #1:
Nome: Maria Green
Email: maria@gmail.com
Quarto: 5
Aluguel #2:
Nome: Marco Antonio
Email: marco@gmail.com
Quarto: 1
Aluguel #3:
Nome: Alex Brown
Email: alex@gmail.com
Quarto: 8
Quartos ocupados:
1: Marco Antonio, marco@gmail.com
5: Maria Green, maria@gmail.com
8: Alex Brown, alex@gmail.com
*/

namespace Exercicio71
{
    class Program
    {
        static void Main()
        {

            Estudante[] quartos = new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #{0}:", i + 1);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int numQuarto = int.Parse(Console.ReadLine());

                quartos[numQuarto] = new Estudante(nome, email);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");

            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine("{0}: {1}", i, quartos[i]);
                }
            }



        }
    }
}
