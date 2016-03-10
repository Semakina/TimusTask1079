using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication36
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] numbers = new int[100000];
            numbers[0] = 0;
            numbers[1] = 1;
            for (i = 2; i < 100000; i++)
            {
                if (i%2 == 0)
                {
                    numbers[i] = numbers[i/2];
                }
                else
                {
                    numbers[i] = numbers[(i - 1)/2] + numbers[(i - 1)/2 + 1];
                }
            }
            int num;
            int max = 0, count = 0;
            int[] results = new int[11];
            for (i = 0;;i++)
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                for (int j = 0; j <= num; j++)
                {
                    if (numbers[j] > max)
                    {
                        max = numbers[j];
                    }
                }
                results[i] = max;
                max = 0;
            }
            count = i;
            for (i = 0; i < count; i++)
            {
                Console.Write(results[i] + " ");
            }
        }
    }
}
