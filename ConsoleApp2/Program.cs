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

            MobSpawner highwyvernSpawner = new MobSpawner(new HighLevelWyvernFactory());
            highwyvernSpawner.SpawnMob();  // Wyvern летает и атакует гоблинов
        }
    }
}
