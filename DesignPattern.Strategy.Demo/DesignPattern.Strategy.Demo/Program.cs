using System;

namespace DesignPattern.Strategy.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your purchase was made in Brazil?: ");
            Console.WriteLine("1.Yes");
            Console.WriteLine("2.No");
            var purchaseOrigin = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Total price of your purchase: ");
            var totalPrice = Convert.ToDecimal(Console.ReadLine().Trim());

            Console.WriteLine("Choose one of the following invoice delivery options:");
            Console.WriteLine("1.E-mail");
            Console.WriteLine("2.File");
            Console.WriteLine("Select invoice delivery options: ");
            var invoiceOption = Convert.ToInt32(Console.ReadLine().Trim());


        }
    }
}
