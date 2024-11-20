using System;
using System.Collections;
using System.Collections.Generic;

namespace _19.Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> num = new List<int> {1, 2, 3,4, 5};
            IEnumerable<int> heloo = num;
            heloo.GetEnumerator();
            num.Add(3);
            num.Insert(1, 8);
            num.RemoveAt(0);
            List<int> list = new List<int>() { 31, 41};
            num.InsertRange(0, list);
            foreach (int i in heloo)
            {
                Console.Write($"{i}, ");
            }
            
            /*
             * Interface về collect
             * 
             * IEnumerable<T> Triển khai nó nếu muốn duyệt phần tử bằng foreach, nó định nghĩa phương thức 
             * GetEnumerator trả về một enumerator
             */
        }
    }
}
