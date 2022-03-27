using NUnit.Framework;
using Контрольная_21_03_2022;

namespace Test
{
    public class CollectionTest
    {
        [Test]
        public void TestAdding()
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(1);

            Assert.AreEqual(queue.QueueToString(), "1");
        }

        [Test]
        public void TestDeleting()
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();

            Assert.AreEqual(queue.QueueToString(), "2");
        }

        [Test]
        public void TestIsEmpty()
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            Assert.IsTrue(queue.IsEmpty());

            queue.Enqueue(1);
            Assert.IsFalse(queue.IsEmpty());
        }

        [Test]
        public void TestSize()
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            var array = new Node<int>[] { new Node<int>(1), new Node<int>(2), new Node<int>(3) };
            Assert.AreEqual(queue.Size(), array.Length);
            queue.Enqueue(5);
            Assert.AreNotEqual(queue.Size(), array.Length);
        }
    }
}