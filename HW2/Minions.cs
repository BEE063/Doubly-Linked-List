using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    public class Minions: IComparable<Minions>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Minions( string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(Minions otherMinion)
        {
            int result = this.Age.CompareTo(otherMinion.Age);
            if(result == 0)
            {
                result = this.Name.CompareTo(otherMinion.Name);
            }
            return result;
        }
    }
}
