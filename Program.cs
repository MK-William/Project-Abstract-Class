using Course.Entities;
using System.Globalization;

namespace ex040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax players: ");
            int n = int.Parse(Console.ReadLine());
            List<People> people = new List<People>();
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax player #1 data: ");
                Console.Write("Individual or company (i/c)?");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
               if (resp == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    people.Add(new PhysicalPerson (name,annualIncome,healthExpenses));
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    people.Add(new LegalEntity(name, annualIncome, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double Sum = 0.0;

            foreach (People p in people)
            {
                Console.WriteLine($"{p.Name}: $ {p.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
                Sum += p.Tax();
            }
            Console.WriteLine($"Total Taxes: {Sum.ToString("F2",CultureInfo.InvariantCulture)}");


        }
    }
}
