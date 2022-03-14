using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinoPolimorfismo2.Entities
{
    internal class Individual : Payer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double income)
            : base(name, income)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            if(Income < 20000.00)
            {
               return (Income * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (Income * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
