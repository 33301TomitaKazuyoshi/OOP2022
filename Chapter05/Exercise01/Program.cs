﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {

            Console.Write("文字列１：");
            var inputString1 = Console.ReadLine();

            Console.Write("文字列２：");
            var inputString2 = Console.ReadLine();

            if (String.Compare(inputString1,inputString2,true) == 0) {
                Console.WriteLine("文字列は等しい。");
            }
        }
    }
}