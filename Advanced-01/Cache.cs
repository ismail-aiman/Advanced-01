using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_01
{
    public class Cache<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }

        public Cache(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        public void Add(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }
        public TValue Get(TKey key)
        {
            return Value;
        }
        public void Remove(TKey key) 
        {

        }
        //i cant understand the requirement of this class well
    }
}
