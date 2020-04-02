using System;
using System.Globalization;

/*Exercício Aula 60: 
Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta.Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente.É preciso haver um mecanismo para proteger
isso.O saldo só aumenta por meio de depósitos, e só diminui por meio de saques.Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial.Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação.
*/

namespace Exercicio60
{
    class Program
    {
        static void Main()
        {
            char depositar;
            double valor;

            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");

            depositar = char.Parse(Console.ReadLine());

            if (depositar == 's' || depositar == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numConta, nome, valor);
            }
            else
            {
                conta = new ContaBancaria(numConta, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
