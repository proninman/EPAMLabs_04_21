using System;
using System.Collections.Generic;
using System.Text;

namespace AT_Lab2_Classes
{
    class Lich : Enemy
    {
        public Lich(string name, int health, int attack, int armor)

        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.armor = armor;
        }
        override public void GetInfo()
        {
            Console.WriteLine($"Лич {name}, Здоровье: {health}, Атака: {attack}, Защита: {armor}");
        }
        public static void Motto()
        {
            Console.WriteLine("Девиз победителя-Счастье мертвецам!");
        }
    }
}
