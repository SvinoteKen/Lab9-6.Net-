using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9__6.Net_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = new List<int>();
            List<int> secondList = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    firstList.Add(random.Next(0, 20));
                    secondList.Add(random.Next(0, 20));

                }
                else
                {
                    firstList.Add(random.Next(0, 20));
                    secondList.Add(random.Next(0, 20));
                }
            }

            Console.WriteLine("Значения первого списка");

            foreach (int items in firstList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\nЗначения второго списка");
            foreach (int item in secondList)
            {
                Console.Write(item + " ");
            }
            int[] numbers = new int[10];
            int y = 0;
            foreach (int second in secondList)
            {
                if (firstList.Contains(second))
                {
                    numbers[y] = second;
                    y++;
                }

            }
            Console.WriteLine();
            firstList.Clear();
            for (int i = 0; i < y; i++)
            {
                if (firstList.Contains(numbers[i])) { continue; }
                if (i == 0)
                {
                    firstList.Add(numbers[i]);
                }
                else
                {
                    firstList.Add(numbers[i]);
                }
            }
            Console.WriteLine("\nРезультат");
            foreach (int items in firstList)
            {
                Console.Write(items + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
