namespace DesignPattern.Behavioral.Mediator.Interfaces
{
    internal interface ILogisticsComponent
    {
        void Send(string message);
        void Publish(string message);
    }
}
