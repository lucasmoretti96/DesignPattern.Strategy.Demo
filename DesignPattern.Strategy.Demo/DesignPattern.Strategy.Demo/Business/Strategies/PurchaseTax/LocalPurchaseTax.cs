using DesignPattern.Strategy.Demo.Business.Models;
using DesignPattern.Strategy.Demo.Business.Strategies.Interfaces;

namespace DesignPattern.Strategy.Demo.Business.Strategies.PurchaseTax
{
    public class LocalPurchaseTax : IPurchaseStrategy
    {
        public decimal GetTaxFor(Order order)
        {
            return order.TotalPrice * 0.30m;
        }
    }
}
