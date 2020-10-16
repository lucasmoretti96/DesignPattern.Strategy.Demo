using DesignPattern.Strategy.Demo.Enums;

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
    }
}
