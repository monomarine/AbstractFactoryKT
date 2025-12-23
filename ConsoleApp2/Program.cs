namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            MobSpawner lowSpawner = new MobSpawner(new LowLevelMobFactory());
            lowSpawner.SpawnMob();

            MobSpawner midSpawner = new MobSpawner(new MidLevelMobFactory());
            midSpawner.SpawnMob();

            MobSpawner highSpawner = new MobSpawner(new NewHighLevelMobFactory());
            highSpawner.SpawnMob();
        }
    }
}