using DesignPattern.Behavioral.ChainOfResponsibility.Interfaces;
using DesignPattern.Behavioral.ChainOfResponsibility.Models;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Handlers
{
    internal class DeliveryHandler : ILogisticsHandler
    {
        private ILogisticsHandler _logisticsHandler;

        public void HandlePackage(Package package)
        {
            if (package.Weight > 100)
                Console.WriteLine("Package handled by Delivery Handler");
            else
                Console.WriteLine("Package is ready for delivery.");
        }

        public void SetSuccessor(ILogisticsHandler handler)
        {
            // the last handler is not needed for the last chain
        }
    }
}
