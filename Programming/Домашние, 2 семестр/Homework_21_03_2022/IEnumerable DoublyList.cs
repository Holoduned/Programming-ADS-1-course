using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Programming.Домашние__2_семестр.Homework_21_03_2022
{
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        public T Data;
        public DoublyNode<T> previous; public DoublyNode<T> next;
    }
    public class DoublyLinkedList<T> : IEnumerable<DoublyNode<T>>
    {
        DoublyNode<T> head;
        DoublyNode<T> tail;
        int count;

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

        IEnumerator<DoublyNode<T>> IEnumerable<DoublyNode<T>>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current;
                current = current.next;
            }
        }

        public void DoublyListPrint()
        {
            foreach (DoublyNode<T> node in this)
            {
                Console.Write(node.Data + " ");
            }
        }
        public void Add(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null) { head = node; }

            else
            {
                tail.next = node;
                node.previous = tail;
            }
            tail = node;
            count++;
        }
    }
}
