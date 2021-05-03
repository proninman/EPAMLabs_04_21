using System;
using System.Collections.Generic;
using System.Text;

namespace AT_Lab2_Classes
{
    class Hero : Enemy
    {
        public Hero(string name, int health, int attack, int armor)

        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.armor = armor;
        }
        override public void GetInfo()
        {
            Console.WriteLine($"Ваш Чемпион- {name}, Здоровье: {health}, Атака: {attack}, Защита: {armor}");
        }
        public static void Motto()
        {
            Console.WriteLine("Девиз победителя-За победу человечества!");
        }
    }
}
