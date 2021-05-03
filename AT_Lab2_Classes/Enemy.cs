using System;
using System.Collections.Generic;
using System.Text;

namespace AT_Lab2_Classes
{
    abstract class Enemy

    {
        public string name;
        public int health;
        public int attack;
        public int armor;
        abstract public void GetInfo();
    }
}
