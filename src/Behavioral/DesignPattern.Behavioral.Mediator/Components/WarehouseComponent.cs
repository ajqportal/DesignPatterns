using DesignPattern.Behavioral.Mediator.Interfaces;

namespace DesignPattern.Behavioral.Mediator.Components
{
    internal class WarehouseComponent : ILogisticsComponent
    {
        private IMediator _mediator;

        public WarehouseComponent(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Publish(string message)
        {
            Console.WriteLine($"Warehouse published: {message}");
        }

        public void Send(string message)
        {
            _mediator.Notify(message, this);
        }
    }
}
