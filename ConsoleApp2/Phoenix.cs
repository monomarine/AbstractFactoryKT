using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Новый моб _ Феникс
    public class Phoenix : IMob
    {
        public void Attack() => Console.WriteLine("Phoenix attacks with firestorm!");
    }
}
