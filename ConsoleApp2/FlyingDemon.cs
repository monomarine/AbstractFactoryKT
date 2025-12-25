using System;

namespace ConsoleApp2
{
    public class FlyingDemon : IMob
    {
        public void Attack() => Console.WriteLine("Flying Demon attacks from the air!");
    }
}