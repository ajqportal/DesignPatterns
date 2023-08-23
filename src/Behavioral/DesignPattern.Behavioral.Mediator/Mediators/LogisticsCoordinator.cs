using DesignPattern.Behavioral.Mediator.Components;
using DesignPattern.Behavioral.Mediator.Interfaces;

namespace DesignPattern.Behavioral.Mediator.Mediators
{
    internal class LogisticsCoordinator : IMediator
    {
        private WarehouseComponent _warehouse;
        private SupplierComponent _supplier;

        public WarehouseComponent Warehouse
        {
            set { _warehouse = value; }
        }

        public SupplierComponent Supplier
        {
            set { _supplier = value; }
        }

        public void Notify(string message, ILogisticsComponent sender)
        {
            if (sender == _warehouse)
            {
                _supplier.Publish(message);
            }
            else if (sender == _supplier)
            {
                _warehouse.Publish(message);
            }
        }
    }
}
