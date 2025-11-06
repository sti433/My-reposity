
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication125
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            float sum = 0, avg;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("enter adad");
                arr[i] = int.Parse(Console.ReadLine());
                sum = sum + arr[i];
            }
            avg = sum / 10;
            Console.WriteLine("sum=" + sum);
            Console.WriteLine("avg=" + avg);
            Console.ReadKey();
        }
    }
}
