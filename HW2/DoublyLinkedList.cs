using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace HW2
{
    public class DoublyLinkedList<T>: IEnumerable<T>
    {
        private Node<T> head;
        private int size;
        private Node<T> tail;
        
        public void AddLast(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                Node<T> current = this.head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                this.tail = current.Next;
            }
            this.size++;
            
            
        }
        public void AddFirst(T element)
        {
            Node<T> newNode = new Node<T>(element);
            if (this.head != null)
            {
                newNode.Next = this.head;
            }
            else
            {
                this.tail = newNode;
            }
            this.head = newNode;
            this.size++;

        }
        public void Delete(T element)
        {
            Node<T> node = this.head;
            Node<T> previous = null;
            while (node != null)
            {
                if (node.Element.Equals(element))
                {
                    if (previous != null)
                    {
                        previous.Next = node.Next;
                    }
                    else if (node.Next == null)
                    {
                        this.tail = previous;
                    }
                    else
                    {
                        this.head = head.Next;
                    }
                    size--;
                    break;
                }
                previous = node;
                node = node.Next;
            }
        }

        public void Edit(T element, T elementEdit)
        {
            Node <T> node= this.head;
            while (node != null)
            {
                if (node.Element.Equals(element))
                {
                    node.Element = elementEdit;
                }
                node = node.Next;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = this.head;
            while (current != null)
            {
                yield return current.Element;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
