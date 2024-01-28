﻿using System.Collections;

namespace DesignPatterns.Behavioral.Iterator
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();

        public abstract bool MoveNext();

        public abstract void Reset();

        public abstract object Current();
    }
}
