// using System;
// using System.Collections;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
//
// namespace Контрольная_21_03_2022
// {
//     class Programm
//     {
//         static void Main(string[] args)
//         {
//             CustomQueue<int> queue = new CustomQueue<int>();
//             queue.Enqueue(1);
//             queue.Enqueue(2);
//             queue.Enqueue(3);
//             queue.Enqueue(4);
//             Console.WriteLine(String.Join(" ", queue.BackEnumerator()));
//             queue.Remove(3);
//             queue.Dequeue();
//             queue.PrintQueue();
//
//             Console.WriteLine(queue.Size());
//             Console.WriteLine(queue.IsEmpty());
//         }
//     }
// }
