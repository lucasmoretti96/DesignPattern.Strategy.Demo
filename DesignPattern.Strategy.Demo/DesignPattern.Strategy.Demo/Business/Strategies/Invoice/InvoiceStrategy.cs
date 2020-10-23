using DesignPattern.Strategy.Demo.Business.Models;
using DesignPattern.Strategy.Demo.Business.Strategies.Interfaces;
using System;

namespace DesignPattern.Strategy.Demo.Business.Strategies.Invoice
{
    public abstract class InvoiceStrategy : IInvoiceStrategy
    {
        public abstract void Generate(Order order);

        public string GenerateTextInvoice(Order order)
        {
            var invoice = $"INVOICE DATE: {DateTimeOffset.Now}{Environment.NewLine}{Environment.NewLine}";

            invoice += $"ID|PURCHASE ORIGIN|TOTAL PRICE{Environment.NewLine}";

            invoice += $"{Guid.NewGuid()}|{order.PurchaseOrigin}|{order.TotalPrice}{Environment.NewLine}";

            invoice += Environment.NewLine + Environment.NewLine;

            var tax = order.GetPurchaseTax();
            var total = order.TotalPrice + tax;

            invoice += $"TAX TOTAL: R${tax}{Environment.NewLine}";
            invoice += $"TOTAL: R${total}{Environment.NewLine}";

            return invoice;
        }
    }
}
