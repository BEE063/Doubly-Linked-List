using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HW2
{
    class MinionsComparator : IComparer<Minions>
    {
        public int Compare(Minions x, Minions y)
        {
            int result = x.Name.CompareTo(y.Name);
            if (result == 0)
            {
                result = y.Age.CompareTo(x.Age);
            }
            return result;
        }
    }
}
