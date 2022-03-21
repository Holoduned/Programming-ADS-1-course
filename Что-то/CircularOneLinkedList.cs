//using System.Collections;

//namespace Programming.Кынтрыльная_заготовки
//{
//    public class CircularOneLinkedList<T> : IEnumerable<Node<T>>
//    {
//        Node<T> head;
//        int count;

//        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

//        IEnumerator<Node<T>> IEnumerable<Node<T>>.GetEnumerator()
//        {
//            Node<T> current = head;
//            while (current != null)
//            {
//                yield return current;
//                current = current.next;
//            }
//        }
//        public void Add(T data)
//        {
//            Node<T> node = new Node<T>(data);

//            if (head == null)
//            {
//                head = node;
//                head.next = head;
//            }
//            else
//            {
//                node.next = head;
//                Node<T> runner = head;
//                while (runner.next != head)
//                {
//                    runner = runner.next;
//                }
//                runner.next = node;

//            }

//            count++;
//        }

//        public void AddFirst(T data)
//        {
//            Node<T> node = new Node<T>(data);
//            node.next = head;
//            head = node;
//            count++;
//        }
//        public Node<T> Last()
//        {
//            var runner = head;
            
//            for (int i = 1; i < count; i++)
//                runner = runner.next;

//            return runner; 
//        }
//        public void RemoveLast()
//        {
//            var runner = head;

//            for (int i = 1; i < count-1; i++)
//                runner = runner.next;
//            head = runner;
//            runner.next = head;
//            count--;
//        }
//        public void RemoveFirst() { head = head.next; Last().next = head; }

//    }
//}
