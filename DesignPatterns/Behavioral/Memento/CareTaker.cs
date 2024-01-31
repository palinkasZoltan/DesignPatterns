namespace DesignPatterns.Behavioral.Memento
{
    internal class CareTaker
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Originator _originator = null;

        public CareTaker(Originator originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("Caretaker: Saving Originator's state");
            IMemento currentState = _originator.SaveState();
            _mementos.Add(currentState);
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            IMemento memento = _mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Restoring state to :" + memento.GetName());

            try
            {
                this._originator.Restore(memento);
            }
            catch (Exception ex)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Here is the list of currently stored mementos: ");
            foreach (IMemento memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
