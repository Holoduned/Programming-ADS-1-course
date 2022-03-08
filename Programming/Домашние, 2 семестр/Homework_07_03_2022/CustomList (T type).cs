using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Programming.Домашние__2_семестр.Homework_07_03_2022
{
    public class Node<T>
    {
        public T Data;
        public Node<T> nextNode;
        public Node(T data)
        {
            Data = data;
        }
    }

    public class CustomList<T>
    {
        Node<T> head;
        int count;
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

                while (runner.nextNode != null)
                {
                    runner = runner.nextNode;
                }
                runner.nextNode = node;

            }
            count++;
        }

        public void AddToFront(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.nextNode = head;
            head = newNode;
            count++;
        }

        public void PrintList()
        {
            Node<T> runner = head;
            while (true)
            {
                if (runner.nextNode != null)
                {
                    Console.Write(runner.Data + " ");
                    runner = runner.nextNode;
                }
                else
                {
                    Console.Write(runner.Data);
                    break;
                }
            }
            Console.WriteLine();
        }

        public void RemoveHead()
        {
            head = head.nextNode;
        }

        public void RemoveLast()
        {
            Node<T> runner = head;

            while (runner.nextNode != null)
            {
                if (runner.nextNode.nextNode == null)
                {
                    runner.nextNode = null;
                    return;
                }
                runner = runner.nextNode;
            }
        }

        public void RemovePreLast()
        {
            Node<T> runner = head;
            Node<T> previous = null;

            while (runner.nextNode != null)
            {
                if (runner.nextNode.nextNode == null)
                {
                    previous.nextNode = runner.nextNode;
                }
                previous = runner;
                runner = runner.nextNode;
            }
        }

        public void AddPosition(T a, int position)
        {
            Node<T> newNode = new Node<T>(a);

            if (position == 1)
            {
                newNode.nextNode = head.nextNode;
                head = newNode;
                return;

            }

            Node<T> runner = head;
            for (int i = 1; i <= position - 2; i++)
            {
                if (runner == null)
                {
                    throw new ArgumentOutOfRangeException("Список недостаточной длины");
                }
                runner = runner.nextNode;
            }

            if (runner.nextNode != null)
            {
                newNode.nextNode = runner.nextNode;
            }
            runner.nextNode = newNode;
        }

        public void RemoveAllElements(T data, bool first = false)
        {
            Node<T> runner = head;
            Node<T> previous = null;

            while (true)
            {
                if (runner.nextNode == null)
                {
                    if (runner.Data.ToString() == data.ToString())
                    {
                        previous.nextNode = null;
                        if (first)
                        {
                            return;
                        }
                    }
                    break;
                }
                else if (head.Data.ToString() == data.ToString())
                {
                    head = head.nextNode;
                    if (first)
                    {
                        return;
                    }
                }
                else if (runner.Data.ToString() == data.ToString())
                {
                    previous.nextNode = runner.nextNode;
                    if (first)
                    {
                        return;
                    }
                }

                count--;
                previous = runner;
                runner = runner.nextNode;
            }
        }

        public void AddBeforeAndAfter(T m, T k)
        {
            Node<T> runner = head;
            Node<T> previous = null;
            Node<T> elementM1 = new Node<T>(m); Node<T> elementM2 = new Node<T>(m);

            while (true)
            {
                if (runner.Data.ToString() == k.ToString() && runner.nextNode == null)
                {
                    runner.nextNode = elementM2;
                    elementM1.nextNode = runner;
                    previous.nextNode = elementM1;
                    return;
                }
                else if (runner.Data.ToString() == k.ToString() && previous == null)
                {
                    elementM2.nextNode = runner.nextNode;
                    runner.nextNode = elementM2;
                    elementM1.nextNode = runner;
                    head = elementM1;
                    return;
                }
                else if (runner.Data.ToString() == k.ToString())
                {
                    elementM2.nextNode = runner.nextNode;
                    runner.nextNode = elementM2;
                    elementM1.nextNode = runner;
                    previous.nextNode = elementM1;
                    return;
                }

                previous = runner;
                runner = runner.nextNode;
            }
        }

        public void Swap()
        {
            Node<T> runner = head;
            int count = 1;

            if (head != null && head.nextNode != null)
            {
                Node<T> newNode = head.nextNode;
                head.nextNode = head.nextNode.nextNode;
                newNode.nextNode = head;
                head = newNode;
                runner = head;
            }

            while (runner.nextNode != null && runner.nextNode.nextNode != null)
            {
                if (count % 2 == 0)
                {
                    Node<T> newNode = runner.nextNode;
                    runner.nextNode = newNode.nextNode;
                    newNode.nextNode = runner.nextNode.nextNode;
                    runner.nextNode.nextNode = newNode;
                }
                count++;
                runner = runner.nextNode; 
            }
        }

        public CustomList<T> Reverse()
        {
            CustomList<T> list = new CustomList<T>();
            Node<T> runner = head;

            while (runner.nextNode != null)
            {
                list.AddToFront(runner.Data);
                runner = runner.nextNode;
                if (runner.nextNode == null) { list.AddToFront(runner.Data); }

            }
            return list;
        }

        public void AddRange(params T[] mas)
        {
            Node<T> runner = head;
            while (runner.nextNode != null)
            {
                runner = runner.nextNode;
            }

            foreach (T item in mas)
            {
                runner.nextNode = new Node<T>(item);
                runner = runner.nextNode;
            }
        }

        public int MaxElement()
        {
            int maxElem = 0;
            Node<T> runner = head;

            if (Num.IsNum(head.Data.ToString()))
            {
                for (int i = 0; i < count; i++)
                {
                    if (Convert.ToInt32(runner.Data) > maxElem)
                    {
                        maxElem = Convert.ToInt32(runner.Data);
                    }
                    runner = runner.nextNode;
                }

                return maxElem;
            }
            else { return 0; }
        }

        public int SumElement()
        {
            int sum = 0;
            Node<T> runner = head;

            if (Num.IsNum(head.Data.ToString()))
            {

                for (int i = 0; i < count; i++)
                {
                    sum += Convert.ToInt32(runner.Data);
                    runner = runner.nextNode;
                }
                return sum;
            }
            else { return 0; }
        }

        public bool NegativeElement()
        {
            bool negative = false;
            Node<T> runner = head;

            for (int i = 0; i < count; i++)
            {
                if (Convert.ToInt32(runner.Data) < 0)
                {
                    negative = true;
                    break;
                }
                runner = runner.nextNode;
            }

            return negative;
        }
    }

    public class Num
    {
        public static bool IsNum(string data)
        {
            try
            {
                var num = int.Parse(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

