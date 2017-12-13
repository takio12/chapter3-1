﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var exists = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            numbers.ForEach(s => Console.WriteLine(s / 2));
            Console.WriteLine(exists);
            var tes = numbers.Where(s => s > 50);
            foreach (var n in tes)
                Console.Write($"{n} ");

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");
        }
            private static void Exercise1_1(List<int> numbers)
            {
                var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);
                if (exist)
                    Console.WriteLine("存在しています");
                else
                    Console.WriteLine("存在していません");
            }

            private static void Exercise1_2(List<int> numbers)
            {
                numbers.ForEach(n => Console.WriteLine(n / 2.0));
            }

            private static void Exercise1_3(List<int> numbers)
            {
                foreach (var n in numbers.Where(x => x >= 50))
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
