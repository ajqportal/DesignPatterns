namespace DesignPattern.Behavioral.Visitor.Interfaces
{
    internal interface IPersonElement
    {
        void Accept(IVisitor visitor);
    }
}
