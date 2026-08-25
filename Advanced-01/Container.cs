using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_01
{
    public class Container<T>
    {
        private T item;

        public void Add(T value) 
        {
            item = value;
        }
        public T Get() 
        {
            return item;
        }
    }
}
