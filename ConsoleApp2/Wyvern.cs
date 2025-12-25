using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Wyvern : IMob
    {
        public void Attack() => Console.WriteLine("Wyvern летает в небе и атакует гоблинов!");

    }
}