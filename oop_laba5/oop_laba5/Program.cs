using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_laba5
{

    class MyCell <T>
    {
        public MyCell<T> Next { get; set; }
        public T Value { get; set; }
        public MyCell<T> _head, _tail;
    }

    class MyQueue <T> : MyCell <T>
    {
        public T[] masOfT = new T[10];

        public void CopyTo(T[] mas)
        {
            int i = 0;
            this.masOfT = mas;
            for(MyCell<T> tmp = _head; tmp != _tail; tmp = tmp.Next, i++)
            {
                masOfT[i] = tmp.Value;
            }
        }

        public int Count { get; private set; }

        public void Enqueue(T value)
        {
            MyCell<T> n = new MyCell<T> { Value = value };
            if (_head == null)
            {
                _head = n;
                _tail = n;
            }
            else
            {
                _tail.Next = n;
                _tail = n;
            }
            Count++;
        }

        public T Dequeue()
        {
            if (Count < 1)
                throw new Exception("Очередь пустая!");
            T tmp = _head.Value;
            _head = _head.Next;
            Count--;
            return tmp;
        }

        public T this[int index]
        {
            get
            {
                return masOfT[index];
            }

            set
            {
                masOfT[index] = value;
            }
        }
        /*
        public void InsertionSort()
        {
            T[] result = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > masOfT[i])
                {
                    result[j] = result[j - 1];
                    j--;
                }
                result[j] = masOfT[i];
            }
        }
        */
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> q = new MyQueue<int>();
            q.Enqueue(50);
            q.Enqueue(150);
            q.Enqueue(500);
            q.Enqueue(50000);
            q.CopyTo(q.masOfT);
            int i = q.masOfT[0];
            Console.Write(i);
            Console.ReadKey();
        }
    }
}
