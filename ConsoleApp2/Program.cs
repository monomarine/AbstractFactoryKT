// Program.cs
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Existing Mobs ===");

            MobSpawner lowSpawner = new MobSpawner(new LowLevelMobFactory());
            lowSpawner.SpawnMob();  // Goblin attacks!

            MobSpawner midSpawner = new MobSpawner(new MidLevelMobFactory());
            midSpawner.SpawnMob();  // Orc attacks!

            MobSpawner highSpawner = new MobSpawner(new HighLevelMobFactory());
            highSpawner.SpawnMob();  // Dragon breathes fire!

            Console.WriteLine("\n=== New High Level Mob ===");

            // Создаем нового моба напрямую (без фабрики, так как нельзя изменять существующий код)
            StoneGolem stoneGolem = new StoneGolem();

            // Используем метод из интерфейса
            stoneGolem.Attack();

            // Используем наши дополнительные методы/свойства
            Console.WriteLine($"Created: {stoneGolem.Name}");
            Console.WriteLine($"Health: {stoneGolem.Health}");
            Console.WriteLine($"Damage: {stoneGolem.Damage}");

            // Если добавили метод DisplayStats
            // stoneGolem.DisplayStats();

            Console.WriteLine("\n=== All mobs spawned successfully! ===");
        }
    }
}