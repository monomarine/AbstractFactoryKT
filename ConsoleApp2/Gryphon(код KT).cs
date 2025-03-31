using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Gryphon : IMob // код кт
    {
        public void Attack() => Console.WriteLine("Грифон атакует выпустив когти!");
    }
}
