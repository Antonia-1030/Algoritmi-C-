using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HW2
{
    class Program
    {
        //1 zadacha

        static void ListSort()
        {
            var nstring = new List<string>() { "njsancs", "uwiqo", "1275", "cheese", "193hakqo", "word now" };
            var stringPartition = nstring.Partition(2);

            for (var count = 0; count < stringPartition; ++count)
            {
                var batch = stringPartition[count];

                Console.Write(count + 1);
                foreach (var item in batch)
                {
                    Console.Write("  " + item);
                }
            }
        }

        //2 zadacha
        static void LongestSame()
        {
            List<int> numbers = new List<int>() { 1,1,342,4564,22,24,67,89,22,22,67,102,78,67,62};

            int[] n = numbers.ToArray();
            List<string> list = new List<string>();
            int temp = 0;
            for (int i = 0; i < n.Length; i++)
            {
                int curr = n[i];
                int next = n[i + 1];
                temp += curr;
                if (curr != next)
                {
                    temp = next;
                }
            }
            Console.WriteLine(list.OrderByDescending(n => n.Length).First()[0]);
        }


            //3 zadacha
            static bool isNegative(int i)
            {
                return ((i-1)<0);
            }

            static void NoNegatives() 
            {
                Random r = new Random();

                List<int> list = new List<int>();
                for (int i = 0; i <= 10; i++)
                {
                    i = r.Next(-20, 20);
                    list.Add(i);
                }
            Console.WriteLine("Списък:");

            foreach (int n in list)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine(" ");

            Console.Write("\nПремахнати елементи: \n");
                Console.Write(list.RemoveAll(isNegative));
                Console.Write(" ");

                Console.Write("\nОставащи елементи:\n");
                foreach (int n in list)
                {
                    Console.WriteLine(n);
                }
            }


        //4 zadacha
        //Реализирайте структурата двойно свързан динамичен списък – списък, чиито елементи
        //имат указател, както към следващия така и към пред­хождащия го елемент. Реализирайте
        //операциите добавяне, премахване и търсене на елемент, добавяне на елемент на
        //определено място (индекс), извличане на елемент по индекс и метод, който връща масив
        //с елементите на списъка.

        public static List<T> Join<T>(this List<T> first, List<T> second)
        {
            if (first == null)
            {
                return second;
            }
            if (second == null)
            {
                return first;
            }

            return first.Concat(second).ToList();
        }
        static void DynamicList()
        {
            List<int> first = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> second = new List<int>() { 6, 7, 8, 9 };

            List<int> result = first.Join(second);
            Console.WriteLine(String.Join(",", result));
        }

        static void Main(string[] args)
        {
            ListSort();
            Console.Write("\n#############\n");
            LongestSame();
            Console.Write("\n#############\n");
            NoNegatives();
            Console.Write("\n#############\n");
            DynamicList();
        }
    }
}
