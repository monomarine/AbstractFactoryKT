using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bomber : IMob
    {
        public void Attack() => Console.WriteLine("Бомбардировщик летит и скидывает бомбы");
    }
}
