namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MobSpawner lowSpawner = new MobSpawner(new LowLevelMobFactory());
            lowSpawner.SpawnMob();  // Goblin attacks!

            MobSpawner midSpawner = new MobSpawner(new MidLevelMobFactory());
            midSpawner.SpawnMob();  // Orc attacks!

            MobSpawner highSpawner = new MobSpawner(new HighLevelMobFactory());
            highSpawner.SpawnMob();  // Dragon breathes fire!

            //добавленный моб
            MobSpawner beeSpawner = new MobSpawner(new BeeFactory());
            beeSpawner.SpawnMob(); //пчёлка жалит!
        }
    }
}
