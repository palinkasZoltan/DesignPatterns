using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral.Memento
{
    internal class Originator
    {
        private string _state;

        public Originator(string state)
        {
            _state = state;
            Console.WriteLine("Originator: My current state is: " + _state);
        }

        public void DoSomething()
        {
            Console.WriteLine("I'm doing somethin important.");
            this._state = this.GenerateRandomState();
            Console.WriteLine("Originator: My current state has changed to: " + _state);
        }

        private string GenerateRandomState(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while(length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];

                Thread.Sleep(12);

                length--;
            }

            return result;
        }

        public IMemento SaveState()
        {
            return new ConcreteMemento(this._state);
        }

        public void Restore(IMemento memento)
        {
            if(!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class: " + memento.ToString());
            }

            this._state = memento.GetState();
            Console.WriteLine("Originator: My state has changed to: " + _state);
        }
    }
}
