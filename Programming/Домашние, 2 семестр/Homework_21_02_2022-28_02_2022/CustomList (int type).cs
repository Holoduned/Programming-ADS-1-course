namespace Programming.Домашние__2_семестр.Homework_21_02_2022
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

    public class CustomList
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

        public static int MaxElement(CustomList list)
        {
            int maxElem = 0;
            Node runner = list.head;

            for (int i = 0; i < list.count; i++)
            {
                if (runner.Data > maxElem)
                {
                    maxElem = runner.Data;
                }
                runner = runner.nextNode;
            }

            return maxElem;
        }

        public static int SumElement(CustomList list)
        {
            int sum = 0;
            Node runner = list.head;

            for (int i = 0; i < list.count; i++)
            {
                sum += runner.Data;
                runner = runner.nextNode;
            }

            return sum;
        }

        public static bool NegativeElement(CustomList list)
        {
            bool negative = false;
            Node runner = list.head;

            for (int i = 0; i < list.count; i++)
            {
                if (runner.Data < 0)
                {
                    negative = true;
                    break;
                }
                runner = runner.nextNode;
            }

            return negative;
        }
        
        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                RemoveHead(); 
                return;
            }

            if (index == count - 1)
            {
                RemoveLast();
                return;
            }  
            var headCopy = head;
            for (int i = 0; i < count - 1; i++)
            {
                if (i == index - 1)
                { headCopy.nextNode = (headCopy.nextNode.nextNode); return; }

                headCopy = headCopy.nextNode; 
            }
        }

        public void RemoveHead()
        {
            if (head == null)
                return;
            head = head.nextNode;
        }

        public void RemoveLast()
        {
            if (head == null)
                return;
            
            Node runner = head;

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
            if (head == null)
                return;
            
            Node runner = head;
            Node previous = null;

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


        public static void RemoveAllElements(CustomList list, int data, bool first = false)
        {
            Node runner = list.head;
            Node previous = null;

            while (true)
            {
                if (runner.nextNode == null)
                {
                    if (runner.Data == data)
                    {
                        previous.nextNode = null;
                        if (first)
                        {
                            return;
                        }
                    }
                    break;
                }
                else if (list.head.Data == data)
                {
                    list.head = list.head.nextNode;
                    if (first)
                    {
                        return;
                    }
                }
                else if (runner.Data == data)
                {
                    previous.nextNode = runner.nextNode;
                    if (first)
                    {
                        return;
                    }
                }

                list.count--;
                previous = runner;
                runner = runner.nextNode;
            }
        }

        public void AddBeforeAndAfter(int m, int k)
        {
            if (head == null)
                return;
            
            Node runner = head;
            Node previous = null;
            Node elementM1 = new Node(m); Node elementM2 = new Node(m);

            while (runner != null)
            {
                if (runner.Data == k && runner.nextNode == null)
                {
                    runner.nextNode = elementM2;
                    elementM1.nextNode = runner;
                    previous.nextNode = elementM1;
                    return;
                }
                else if (runner.Data == k && previous == null)
                {
                    elementM2.nextNode = runner.nextNode;
                    runner.nextNode = elementM2;
                    elementM1.nextNode = runner;
                    head = elementM1;
                    return;
                }
                else if (runner.Data == k)
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

