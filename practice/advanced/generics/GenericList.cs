using System;

namespace practice.advanced.generics
{
    public class GenericList<T>
    {
        public void Add(T value){}

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }

    }
}
