using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Кынтрыльная_заготовки
{
    public class CircularTwoLinkedList<T> : IEnumerable<DoublyNode<T>>
    {
        DoublyNode<T> head;
        int count;

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

        IEnumerator<DoublyNode<T>> IEnumerable<DoublyNode<T>>.GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current;
                current = current.next;
            }
        }
        public void Add(T data)
        {
            var node = new DoublyNode<T>(data);

            if (head == null)
            {
                head = node;
                head.next = node;
                head.previous = node;
            }
            else
            {
                node.previous = head.previous;
                node.next = head;
                head.previous.next = node;
                head.previous = node;
            }
            count++;

        }
        public void AddFirst(T data)
        {
            var node = new DoublyNode<T>(data);
            node.next = head;
            head.previous = node;
            head = node;
            count++;
        }
        public DoublyNode<T> Last()
        {
            var runner = head;

            for (int i = 1; i < count; i++)
                runner = runner.next;

            return runner;
        }
        public void RemoveLast()
        {
            Last().previous.next = head;
            count--;
        }
        public void RemoveFirst() { head = head.next; Last().next = head; }
    }
}
