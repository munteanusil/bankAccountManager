using System.Runtime.InteropServices;

namespace Conventions
{
    public enum EmployType
    {
        Manager,
        Salesman,
        Dev
    }
    public static class SallaryCalculator
    {
        public static void CalculateSallary(EmployType employType, string name)
        {
            var tup = (employType, name);
            switch (tup)
            {
                case (EmployType.Manager, "Ion"):
                    Console.WriteLine("Sallary is 20000");
                    break;
                case (EmployType.Dev, "Nicu"):
                    Console.WriteLine("Sallary is 30000");
                    break;
                default:
                    Console.WriteLine("Confidential");
                    break;
            }

        }

    }
}
