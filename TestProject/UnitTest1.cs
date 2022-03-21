using Microsoft.VisualStudio.TestTools.UnitTesting;
using Programming;
using System.Collections;
using System;
using System.Linq;
using Контрольная_21_03_2022;

namespace Test
{
    [TestClass]
    public class CollectionTest
    {
        [TestMethod]
        public void TestAdding()
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(1);

            Assert.AreEqual(queue.QueueToString(), "1");
        }

        [TestMethod]
        public void TestDeleting()
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Dequeue();

            Assert.AreEqual(queue.QueueToString(), "2");
        }

        [TestMethod]
        public void TestIsEmpty()
        {
            CustomQueue<int> queue = new CustomQueue<int>();
            Assert.IsTrue(queue.IsEmpty());

            queue.Enqueue(1);
            Assert.IsFalse(queue.IsEmpty());
        }

        [TestMethod]
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