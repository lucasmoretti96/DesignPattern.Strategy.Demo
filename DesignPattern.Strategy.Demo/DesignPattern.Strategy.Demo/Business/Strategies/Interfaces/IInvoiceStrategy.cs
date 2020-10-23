using DesignPattern.Strategy.Demo.Business.Models;

namespace DesignPattern.Strategy.Demo.Business.Strategies.Interfaces
{
    public interface IInvoiceStrategy
    {
        public void Generate(Order order);
    }
}
