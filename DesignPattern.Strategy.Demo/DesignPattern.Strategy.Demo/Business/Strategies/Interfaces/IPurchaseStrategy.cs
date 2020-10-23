using DesignPattern.Strategy.Demo.Business.Models;

namespace DesignPattern.Strategy.Demo.Business.Strategies.Interfaces
{
    public interface IPurchaseStrategy
    {
        public decimal GetTaxFor(Order order);
    }
}
