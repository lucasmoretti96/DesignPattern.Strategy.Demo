using DesignPattern.Strategy.Demo.Business.Models;
using DesignPattern.Strategy.Demo.Business.Strategies.Interfaces;
using DesignPattern.Strategy.Demo.Business.Strategies.Invoice;
using DesignPattern.Strategy.Demo.Business.Strategies.PurchaseTax;
using DesignPattern.Strategy.Demo.Enums;
using DesignPattern.Strategy.Demo.Extensions;
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
            var purchaseOrigin = Convert.ToInt32(Console.ReadLine().Trim()).TryParseToEnum<PurchaseOriginEnum>();

            Console.WriteLine("Total price of your purchase in R$: ");
            var totalPrice = Convert.ToDecimal(Console.ReadLine().Trim());

            Console.WriteLine("Choose one of the following invoice delivery options:");
            Console.WriteLine("1.E-mail");
            Console.WriteLine("2.File");
            Console.WriteLine("Select invoice delivery options: ");
            var invoiceOption = Convert.ToInt32(Console.ReadLine().Trim()).TryParseToEnum<InvoiceOptionEnum>();

            var order = new Order(purchaseOrigin, totalPrice, invoiceOption);

            Console.WriteLine($"Price: R${order.TotalPrice}");
            Console.WriteLine($"Tax: R${order.GetPurchaseTax()}");
            Console.WriteLine($"Total Price: R${order.TotalPrice + order.GetPurchaseTax()}");
            Console.WriteLine($"Tipe of purchase: {order.PurchaseOrigin.Value}");
            Console.WriteLine($"Invoice option: {order.InvoiceOption.Value}");

            order.FinalizeOrder();
        }
    }
}
