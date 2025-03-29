using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Megaladon : IMob
    {
        public void Attack() => Console.WriteLine("Мегаладон атакует мощным потоком воды!");
    }
}
