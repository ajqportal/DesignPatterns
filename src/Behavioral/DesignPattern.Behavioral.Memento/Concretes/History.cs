namespace DesignPattern.Behavioral.Memento.Concretes
{
    internal class History
    {
        private Stack<Models.Memento> mementos = new Stack<Models.Memento>();

        public void Save(Models.Memento memento)
            => mementos.Push(memento);

        public Models.Memento? Undo()
        {
            if(mementos.Count > 0)
                return mementos.Pop();

            return null;
        }
    }
}
