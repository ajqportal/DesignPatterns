using DesignPattern.Behavioral.ChainOfResponsibility.Models;

namespace DesignPattern.Behavioral.ChainOfResponsibility.Interfaces
{
    internal interface ILogisticsHandler
    {
        void SetSuccessor(ILogisticsHandler handler);
        void HandlePackage(Package package);
    }
}
