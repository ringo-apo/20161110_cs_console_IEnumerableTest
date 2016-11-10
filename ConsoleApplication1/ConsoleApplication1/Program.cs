using System;
using System.Collections;

namespace ConsoleApplication1
{
    class IntArray : IEnumerable
    {
        private int[] arr;

        public IntArray(int[] arr)
        {
            this.arr = arr;
        }

        // インデクサ
        public int this[int index]
        {
            get { return arr[index]; }
            set { arr[index] = value; }
        }

        // 長さ
        public int Length
        {
            get { return arr.Length; }
        }

        // IEnumerable.GetEnumeratorの実装
        public IEnumerator GetEnumerator()
        {
            // Array.GetEnumerator()の戻り値を流用する
            return arr.GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IntArray arr = new IntArray(new int[] { 0, 1, 2, 3, 4 });

            foreach (int _ in arr)
            {
                Console.WriteLine(_);
            }
            Console.ReadLine();
        }
    }
}
