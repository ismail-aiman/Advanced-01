using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_01
{
    public class Struct_example<T> where T : struct
    {
        public T MyProperty { get; set; }
    }
}
