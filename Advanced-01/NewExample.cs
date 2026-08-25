using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_01
{
    public class NewExample<T> where T : new()
    {
        public NewExample() { }
    }
}
