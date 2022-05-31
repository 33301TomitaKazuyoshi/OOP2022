using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Console.WriteLine("-----");

            Exercise3_2(text);
            Console.WriteLine("-----");

            Exercise3_3(text);
            Console.WriteLine("-----");

            Exercise3_4(text);
            Console.WriteLine("-----");

            Exercise3_5(text);
        }

        private static void Exercise3_1(string text) {
            var spaces = text.Count(c => c == ' ');
            Console.WriteLine("空白数：{0}", spaces);
        }

        private static void Exercise3_2(string text) {
            //P146
            var replaced = text.Replace("big", "small");
            Console.WriteLine(replaced);
        }

        private static void Exercise3_3(string text) {
            //p148～p149
            var words = text.Split(' ').Length;
            Console.WriteLine("単語数：{0}", words);
        }

        private static void Exercise3_4(string text) {
            var s = text.Split(' ').Where(word => word.Length <= 4);
            foreach (var item in s) {
                Console.WriteLine(item);
            }
        }

        private static void Exercise3_5(string text) {
            var array = text.Split(' ').ToArray();
            if (array.Length > 0) {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {

                    sb.Append(' ');
                    sb.Append(word);
                }

                var str = sb.ToString();
                Console.WriteLine(str);
            }
        }
    }
}
