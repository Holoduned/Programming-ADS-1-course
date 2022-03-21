using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Контрольная_21_03_2022
{
    public class Node<T>
    {
        public T Data;
        public Node<T> next;
        public Node(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }

    public class LinkedList<T> : IEnumerable<Node<T>>
    {
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

        IEnumerator<Node<T>> IEnumerable<Node<T>>.GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return current;
                current = current.next;
            }
        }

        public Node<T> head;
        public int count;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> runner = head;

                while (runner.next != null)
                {
                    runner = runner.next;
                }
                runner.next = node;

            }
            count++;
        }
        public T RemoveHead()
        {
            T first = head.Data;
            head = head.next;
            count--;
            return first;
        }

        public void RemoveLast()
        {
            Node<T> runner = head;

            while (runner.next != null)
            {
                if (runner.next.next == null)
                {
                    runner.next = null;
                    return;
                }
                runner = runner.next;
            }
        }

        public void Remove(int index)
        {
            Node<T> runner = head;
            Node<T> previous = null;

            for (int i = 1; i <= count; i++)
            {
                if (index == 1)
                {
                    RemoveHead();
                    break;
                }
                else if (index == count)
                {
                    RemoveLast();
                    break;
                }

                else if (i == index)
                {
                    previous.next = runner.next;
                    break;
                }
                previous = runner;
                runner = runner.next;
            }
        }

    }


    public class CustomQueue<T> : IEnumerable<Node<T>>
    {
        LinkedList<T> list = new();
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

        IEnumerator<Node<T>> IEnumerable<Node<T>>.GetEnumerator()
        {
            Node<T> current = list.head;
            while (current != null)
            {
                yield return current;
                current = current.next;
            }
        }
        public IEnumerable<Node<T>> BackEnumerator()
        {
            var newlist = list.ToList();
            newlist.Reverse();

            foreach (var item in newlist)
                yield return item;
        }

        public void Enqueue(T item)
        {
            list.Add(item);
        }

        public void Dequeue()
        {
            list.RemoveHead();
        }

        public int Size()
        {
            return list.count;
        }

        public bool IsEmpty()
        {
            return !list.Any();
        }

        public void Remove(int index)
        {
            list.Remove(index);
        }
        public void PrintQueue()
        {
            foreach (Node<T> node in this)
            {
                Console.Write(node.Data + " ");
            }
            Console.WriteLine();
        }

        public string QueueToString()
        {
            string s = "";
            foreach(Node<T> node in this)
            {
                s += node.ToString();
            }

            return s;
        }
    }
}
