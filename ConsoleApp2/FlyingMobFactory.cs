using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    // Фабрика для создания Феникса
    public class FlyingMobFactory : IMobFactory
    {
        public IMob CreateMob() => new Phoenix();
    }
}
