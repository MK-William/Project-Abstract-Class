
using System.Xml.Linq;

namespace Course.Entities
{
    internal class PhysicalPerson : People
    {
        public double HealthExpenses { get; set; }

        public PhysicalPerson(string name,double annualIncome,double healthExpenses)
            :base(name,annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnnualIncome <= 20000.0)
            {
                tax = AnnualIncome * 0.15;
            } else
            {
                tax = AnnualIncome * 0.25;
            }
            if (HealthExpenses > 0)
            {
                tax -= HealthExpenses * 0.50;
            }
            return tax;
        }
    }
}
