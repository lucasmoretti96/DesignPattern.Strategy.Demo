using DesignPattern.Strategy.Demo.Business.Models;
using System;
using System.IO;

namespace DesignPattern.Strategy.Demo.Business.Strategies.Invoice
{
    public class FileInvoiceStrategy : InvoiceStrategy
    {
        public override void Generate(Order order)
        {
            var fileName = $"invoice_{Guid.NewGuid()}.txt";
            using (var stream = new StreamWriter(fileName))
            {
                stream.Write(GenerateTextInvoice(order));

                stream.Flush();

                Console.WriteLine($"Invoice for order saved to {fileName}");
            }
        }
    }
}
