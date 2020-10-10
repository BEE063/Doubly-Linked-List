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

        }
    }
}
