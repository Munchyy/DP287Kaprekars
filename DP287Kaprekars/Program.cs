using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP287Kaprekars
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = { 1234, 3253, 9800, 333, 120 };
            int[] kaprekarInputs = { 6589, 5455, 6174 };

            Kaprekars kap = new Kaprekars();
            foreach(int i in inputs)
            {
                Console.WriteLine("Largest digit in {0} is {1}", i, kap.LargestDigit(i));
            }

            foreach (int i in inputs)
            {
                Console.WriteLine("The number {0} in order is {1}", i, kap.SortDigits(i));
            }

            foreach(int i in kaprekarInputs)
            {
                int result = kap.KaprekarRoutine(i);
                if (result == -1)
                    Console.WriteLine("Requires at least 2 different digist");
                else
                    Console.WriteLine("The Number of steps for {0} to reach the Kaprekar number is {1}", i, result);
            }

            Console.ReadLine();
        }
    }
}
