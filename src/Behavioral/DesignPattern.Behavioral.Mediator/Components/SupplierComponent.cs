using DesignPattern.Behavioral.Mediator.Interfaces;

namespace DesignPattern.Behavioral.Mediator.Components
{
    internal class SupplierComponent : ILogisticsComponent
    {
        private IMediator _mediator;

        public SupplierComponent(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Publish(string message)
        {
            Console.WriteLine($"Supplier published: {message}");
        }

        public void Send(string message)
        {
            _mediator.Notify(message, this);
        }
    }
}
