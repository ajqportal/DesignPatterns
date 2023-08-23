using DesignPattern.Behavioral.ChainOfResponsibility.Interfaces;
using DesignPattern.Behavioral.ChainOfResponsibility.Models;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Handlers
{
    internal class ShippingHandler : ILogisticsHandler
    {
        private ILogisticsHandler _logisticsHandler;

        public void HandlePackage(Package package)
        {
            if (package.Weight > 10 && package.Weight <= 100)
                Console.WriteLine("Package handled by Shipping Handler");

            if (_logisticsHandler is not null)
                _logisticsHandler.HandlePackage(package);
        }

        public void SetSuccessor(ILogisticsHandler handler)
            => _logisticsHandler = handler;
    }
}
