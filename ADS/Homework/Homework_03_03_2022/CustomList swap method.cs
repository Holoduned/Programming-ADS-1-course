using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADS.Homework.Homework_03_03_2022
{
    public class Node
    {
        public int Data;
        public Node nextNode;
        public Node(int data)
        {
            Data = data;
        }
    }

    internal class CustomList
    {
        Node head;
        int count;

        public void Add(int data)
        {
            Node node = new Node(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node runner = head;

                while (runner.nextNode != null)
                {
                    runner = runner.nextNode;
                }
                runner.nextNode = node;

            }
            count++;
        }
        public void Swap()
        {
            Node runner = head;
            int count = 1;

            if (head != null && head.nextNode != null)
            {
                Node newNode = head.nextNode;
                head.nextNode = head.nextNode.nextNode;
                newNode.nextNode = head;
                head = newNode;
                runner = head;
            }

            while (runner.nextNode != null && runner.nextNode.nextNode != null)
            {
                if (count % 2 == 0)
                {
                    Node newNode = runner.nextNode;
                    runner.nextNode = newNode.nextNode;
                    newNode.nextNode = runner.nextNode.nextNode;
                    runner.nextNode.nextNode = newNode;
                }
                count++;
                runner = runner.nextNode;
            }
        }

        public void PrintList()
        {
            Node runner = head;
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
    }
}
