using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HW2
{
    public class Stack<T>: IEnumerable<T>
    {
        private T[] items;
        private int size;
        private readonly int initCapacity = 5;
        public Stack()
        {
            this.items = new T[initCapacity];
            this.size = 0;
        }
         
        public int Size()
        {
           return size;
        }

        public void Add(T element)
        {
            if (items.Length == size)
                Resize(items.Length * 2);
            items[size++] = element;
        }
        public bool IsEmpty()
        {
            if (size == 0)
            {
                return true;
            }
            else
                return false;
        }
        public void Remove()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            else
            {
                this.size--;
                T[] elements = new T[size];
                for(int i =0; i<size; i++)
                {
                    elements[i] = this.items[i];
                }
                this.items = elements;
            }
        }
       private void Resize(int max)
        {
            T[] newItems = new T[max];
            for(int i =0; i<size; i++)
            {
                newItems[i] = items[i];
            }
            items = newItems;
        }
        public IEnumerator<T> GetEnumerator()
            {
                for(int i=this.size -1; i >=0; i--)
                {
                    yield return this.items[i];
                }
            }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
