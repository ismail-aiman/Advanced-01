using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_01
{
    public class Pair<TKey, TValue>
    {
        public Pair(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
}
