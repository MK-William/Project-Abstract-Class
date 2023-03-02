
namespace Course.Entities
{
    internal class LegalEntity : People
    {
        public int Employees { get; set; }

        public LegalEntity(string name , double annualIncome,int employees)
            :base(name,annualIncome)
        {
            Employees = employees;
        }

        public override double Tax()
        {
            if (Employees <= 10 ) 
            {
                return AnnualIncome * 0.16;
            } else
            {
                return AnnualIncome * 0.14;
            }
        }
    }
}
