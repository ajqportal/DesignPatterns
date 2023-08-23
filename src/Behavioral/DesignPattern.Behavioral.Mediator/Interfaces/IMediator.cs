namespace DesignPattern.Behavioral.Mediator.Interfaces
{
    internal interface IMediator
    {
        void Notify(string message, ILogisticsComponent sender);
    }
}
