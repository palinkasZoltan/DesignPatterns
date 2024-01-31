namespace DesignPatterns.Behavioral.Memento
{
    internal class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            _state = state;
            _date = DateTime.Now;
        }

        public string GetState() => _state;

        public DateTime GetDate() => _date;

        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }
    }
}
