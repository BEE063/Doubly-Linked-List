using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    public class Minions
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Minions( string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
