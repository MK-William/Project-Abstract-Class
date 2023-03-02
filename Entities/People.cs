using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    abstract class People
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();

    }
}
