using Exercicio145.Exceptions;

namespace Exercicio145.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {

            if (amount > WithDrawLimit)
            {
                throw new AppException("Withdraw error: The amount exceeds withdraw limit");
            }
            else if (Balance < amount)
            {
                throw new AppException("Withdraw error: Not enough balance");
            }

            Balance -= amount;

        }
    }
}
