using DesignPattern.Strategy.Demo.Business.Strategies.Interfaces;
using DesignPattern.Strategy.Demo.Business.Strategies.Invoice;
using DesignPattern.Strategy.Demo.Business.Strategies.PurchaseTax;
using DesignPattern.Strategy.Demo.Enums;
using System;

namespace DesignPattern.Strategy.Demo.Business.Models
{
    public class Order
    {
        public Order(PurchaseOriginEnum? purchaseOrigin, decimal totalPrice, InvoiceOptionEnum? invoiceOption)
        {
            PurchaseOrigin = purchaseOrigin;
            TotalPrice = totalPrice;
            InvoiceOption = invoiceOption;
        }

        public PurchaseOriginEnum? PurchaseOrigin { get; set; }
        public decimal TotalPrice { get; set; }
        public InvoiceOptionEnum? InvoiceOption { get; set; }
        public IPurchaseStrategy PurchaseStrategy => GetPurchaseStrategy(this.PurchaseOrigin);
        public IInvoiceStrategy InvoiceStrategy => GetInvoiceStrategy(this.InvoiceOption);

        public decimal GetPurchaseTax()
        {
            if (PurchaseStrategy == null)
                return 0m;

            return PurchaseStrategy.GetTaxFor(this);
        }

        public void FinalizeOrder()
        {
            InvoiceStrategy.Generate(this);
        }

        private static IPurchaseStrategy GetPurchaseStrategy(PurchaseOriginEnum? purchaseOrigin)
        {
            if (purchaseOrigin == PurchaseOriginEnum.LocalPurchase)
                return new LocalPurchaseTax();
            else if (purchaseOrigin == PurchaseOriginEnum.ForeignPurchase)
                return new ForeignPurchaseTax();
            else
                throw new Exception("Unsupported purchase origin");
        }

        private static IInvoiceStrategy GetInvoiceStrategy(InvoiceOptionEnum? invoiceOption)
        {
            return invoiceOption.Value switch
            {
                InvoiceOptionEnum.Email => new EmailInvoiceStrategy(),
                InvoiceOptionEnum.File => new FileInvoiceStrategy(),
                _ => throw new Exception("Unsupported invoice delivery option"),
            };
        }
    }
}
