using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HighLevelSkeletonFactory : IMobFactory
    {
        public IMob CreateMob() => new skeleton();
    }
}
