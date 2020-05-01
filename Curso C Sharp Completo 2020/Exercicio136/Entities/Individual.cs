using System.Globalization;

namespace Exercicio136.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
        }
    }
}
