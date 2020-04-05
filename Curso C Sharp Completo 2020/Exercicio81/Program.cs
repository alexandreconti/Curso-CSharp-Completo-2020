using System;

/*Fazer um programa para ler dois números inteiros M e N, e depois ler
uma matriz de M linhas por N colunas contendo números inteiros,
podendo haver repetições. Em seguida, ler um número inteiro X que
pertence à matriz. Para cada ocorrência de X, mostrar os valores à
esquerda, acima, à direita e abaixo de X, quando houver, conforme
exemplo.

3 4
10 8 15 12
21 11 23 8
14 5 13 19
8
Position 0,1:
Left: 10
Right: 15
Down: 11
Position 1,3:
Left: 23
Up: 12
Down: 19 
*/


namespace Exercicio81
{
    class Program
    {
        static void Main()
        {
            string[] dimension = Console.ReadLine().Split(" ");

            int m = int.Parse(dimension[0]);
            int n = int.Parse(dimension[1]);

            int[,] matrix = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine().Split();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");

                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + matrix[i, j - 1]);
                        }

                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + matrix[i, j + 1]);
                        }

                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matrix[i - 1, j]);
                        }

                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + matrix[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}
