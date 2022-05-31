﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");

            Exercise1_5(numbers);
        }
        //最大値
        private static void Exercise1_1(int[] numbers) {
            var max = numbers.Max();
            Console.WriteLine(max);
        }
        //最後から２つの要素取り出し
        private static void Exercise1_2(int[] numbers) {
            foreach (var n in numbers.Skip(numbers.Length - 2)) {
                Console.WriteLine(n);
            }
        }
        //数値を文字列に変換
        private static void Exercise1_3(int[] numbers) {
            foreach (var items in numbers.Select(n => n)) {
                Console.WriteLine(items);
            }
        }
        //小さい順に並べて先頭の３つを出力
        private static void Exercise1_4(int[] numbers) {
            var sortedNumbers = numbers.OrderBy(n => n);
            Console.WriteLine();
        }
        //重複を排除し１０より大きい数がいくつあるか
        private static void Exercise1_5(int[] numbers) {
            var count = numbers.Distinct().Count(n => n > 10);
            Console.WriteLine(count);
        }
    }
}
