using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_01
{
    public class MultipleConstraintsExample<T> where T : Animal, IComparable<T>, new()
    {
    }
}
