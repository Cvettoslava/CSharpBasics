using System;

namespace Methods
{
    class Cat
    {
        void SayMeow()
        {
            Console.WriteLine("Meow!");
        }

        static void Main(string[] args)
        {
            Cat johnny = new Cat();

            johnny.SayMeow();
        }
    }
}
