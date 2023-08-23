using DesignPattern.Behavioral.ChainOfResponsibility.Interfaces;
using DesignPattern.Behavioral.ChainOfResponsibility.Models;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Handlers
{
    internal class WarehouseHandler : ILogisticsHandler
    {
        private ILogisticsHandler _logisticshandler;

        public void HandlePackage(Package package)
        {
            if (package.Weight <= 10)
                Console.WriteLine("Package handled by Warehouse Handler");

            if (_logisticshandler is not null)
                _logisticshandler.HandlePackage(package);
        }

        public void SetSuccessor(ILogisticsHandler handler)
            => _logisticshandler = handler;
    }
}
