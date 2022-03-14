using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoPolimorfismo2.Entities
{
    internal class Company : Payer
    {
        public double NumberEmployees { get; set; }

        public Company(double numberEmployees, string name, double income)
            : base(name, income)
        {
            NumberEmployees = numberEmployees;
        }

        public override double Taxes()
        {
            if (NumberEmployees <= 10)
            {
                return Income * 0.16;
            }
            else
            {
                return Income * 0.14;
            }
        }
    }
}
