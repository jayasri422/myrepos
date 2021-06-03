using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d10t1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 23, 11, 19, 55, 67, 83 };
            Array.Sort(arr);
            Array.Reverse(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
