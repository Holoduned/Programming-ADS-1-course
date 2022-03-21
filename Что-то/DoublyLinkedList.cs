using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Кынтрыльная_заготовки
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

        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            node.next = head;
            head.previous = node;
            head = node;

            if (count == 0)
            {
                tail = head;
            }

            count++;
        }

        public void RemoveLast()
        {
            this.Last().previous.next = null;
        }

        public void RemoveFirst()
        {
            head = head.next;
        }

    }
}
