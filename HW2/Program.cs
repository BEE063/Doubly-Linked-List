using System;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            Minions minion1 = new Minions("Jimmy", 16);
            Minions minion2 = new Minions("Jenny", 21);
            Minions minion3 = new Minions("Bob", 12);
            Minions minion4 = new Minions("Alice", 17);

            DoublyLinkedList<Minions> minionsList = new DoublyLinkedList<Minions>();
            minionsList.AddLast(minion1);
            minionsList.AddLast(minion2);
            minionsList.AddFirst(minion3);
            minionsList.AddLast(minion4);
            minionsList.Delete(minion1);
            minionsList.Edit(minion3, minion1);
            foreach (var m in minionsList)
            {
                Console.WriteLine(m.Name+" "+ m.Age);
            }

            Console.WriteLine(minionsList[2].Name);

            Stack<Minions> stack = new Stack<Minions>();
  
            stack.Add(minion1);
            stack.Add(minion2);
            stack.Add(minion3);
            stack.Add(minion4);
            stack.Remove();
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.Size());
            foreach(var s in stack)
            {
                Console.WriteLine(s.Name) ;
            }

            MinionsComparator minionsComparator = new MinionsComparator();

            Console.WriteLine(minion1.CompareTo(minion2));
            Console.WriteLine(minionsComparator.Compare(minion1, minion2));
        }
    }
}
