using System;

namespace ConsoleApp2
{
    public class StoneGolem : IMob
    {
        // Добавляем свойства, которых нет в интерфейсе
        public string Name { get; } = "Stone Golem";
        public int Health { get; } = 250;
        public int Damage { get; } = 45;

        public void Attack()
        {
            Console.WriteLine($"{Name} smashes with massive stone fists!");
        }

        // Дополнительный метод для демонстрации свойств
        public void DisplayStats()
        {
            Console.WriteLine($"{Name} - Health: {Health}, Damage: {Damage}");
        }
    }
}