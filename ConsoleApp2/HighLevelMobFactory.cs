using System;

namespace ConsoleApp2
{
    public class HighLevelMobFactory : IMobFactory
    {
        public IMob CreateMob()
        {
            Random random = new Random(); //чисто по приколу
            return random.Next(2) == 0 ? new Dragon() : new FlyingDemon();
        }
    }
}