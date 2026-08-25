using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_01
{
    public class BaseClassExample<T> where T : Animal
    {
        public void MakeAnimalSpeak(T animal)
        {
            animal.Speak();
        }
    }
    public class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
