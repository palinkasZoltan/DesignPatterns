namespace DesignPatterns.Behavioral.Iterator
{
    internal class AlphabeticalIterator : Iterator
    {
        private WordsCollection _collection;

        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalIterator(WordsCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            int newPosition = _position + (_reverse ? -1 : 1);

            if(newPosition >= 0 && newPosition < _collection.GetItems().Count)
            {
                _position = newPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}
