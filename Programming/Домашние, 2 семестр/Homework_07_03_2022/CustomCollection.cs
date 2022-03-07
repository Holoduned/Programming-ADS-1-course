using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Programming.Домашние__2_семестр.Homework_07_03_2022
{
    public interface ICustomCollection<T>
    {
        int Size();
        bool isEmpty();
        bool Contains(T elem);
        void Add(T elem);
        void AddRange(T[] elems);

        /// <summary>
        /// Удаление элемента со значением
        /// </summary>
        void Remove(T elem);

        /// <summary>
        /// Удаляет все элементы со значением
        /// </summary>
        void RemoveAll(T elem);

        /// <summary>
        /// Удаление элемента на позиции с номером 
        /// </summary>
        void RemoveAt(int index);
        void Clear();
        void Reverse();

        /// <summary>
        /// Вставка элемента на конкретную позицию
        /// </summary>
        void Insert(int index, T elem);
        int IndexOf(T elem);
        void Print();
    }

    public class CustomArrayCollection<T> : ICustomCollection<T>
    {
        private T[] array = Array.Empty<T>();

        public int Size()
        {
            return array.Length;
        }

        public bool isEmpty()
        {
            if (array.Length == 0 && array == null)
            {
                return true;
            }
            return false;
        }

        public bool Contains(T element)
        {
            if (array.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Add(T element)
        {
            array.Append(element).ToArray();

        }

        public void AddRange(params T[] mas)
        {
            array = array.Concat(mas).ToArray();
        }

        public int IndexOf(T element)
        {
            return Array.IndexOf(array, element);
        }

        public void Reverse()
        {
            Array.Reverse(array);
        }

        public void Clear()
        {
            array = Array.Empty<T>();
        }

        public void Remove(T element)
        {

        }

        public void RemoveAll(T element)
        {

        }

        public void RemoveAt(int index)
        {

        }

        public void Insert(int index, T element)
        {

        }

        public void Print()
        {
            Console.WriteLine(String.Join(" ", array));
        }
    }

}
