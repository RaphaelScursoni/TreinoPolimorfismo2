namespace TreinoPolimorfismo2.Entities
{
    internal abstract class Payer
    {
        public string Name { get; set; }
        public double Income { get; set; }

        public Payer(string name, double income)
        {
            Name = name;
            Income = income;
        }

        public abstract double Taxes();  
    }
}
