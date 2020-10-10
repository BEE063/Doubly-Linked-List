using System;
using System.Collections.Generic;
using System.Text;

namespace HW2
{
    public class Node<T>
    {
        public T Element { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Previous { get; set; }

        public Node(T element)
        {
            Element = element;
        }
    }
}
