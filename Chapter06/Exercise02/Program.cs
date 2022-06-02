using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            var books = new List<Book> {
               new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
               new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
               new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
               new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
               new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
               new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
               new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);
            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);
            Console.WriteLine("-----");

            Exercise2_7(books);
            Console.WriteLine("-----");

            Exercise2_8(books);
            Console.WriteLine("-----");
        }

        

        private static void Exercise2_1(List<Book> books) {
            var data = books.Where(b => b.Title == "ワンダフル・C#ライフ").Select(b => new { b.Price, b.Pages });
            foreach(var items in data) {
                Console.WriteLine(items);
                    
            }
                
        }

        private static void Exercise2_2(List<Book> books) {
            var count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<Book> books) {
            var average = books.Where(n => n.Title.Contains("C#")).Average(n => n.Pages);
            Console.WriteLine(average);
        }

        private static void Exercise2_4(List<Book> books) {
            var firstFind = books.FirstOrDefault(n => n.Price >= 4000);
            if (firstFind != null) {
                Console.WriteLine(firstFind.Title);
            }
        }

        private static void Exercise2_5(List<Book> books) {
            var maxPages = books.Where(n => n.Price < 4000).Max(n => n.Pages);
                Console.WriteLine(maxPages);
        }

        private static void Exercise2_6(List<Book> books) {
            var priceDescending = books.Where(n => n.Pages >= 400).OrderByDescending(n => n.Price);
            foreach (var n in priceDescending) {
                Console.WriteLine(n.Title + ":" + n.Price);
            }
        }

        private static void Exercise2_7(List<Book> books) {
            var book = books.Where(n => n.Title.Contains("C#") && n.Pages <= 500);
            foreach (var items in book) {
                Console.WriteLine(items.Title);
            }
        }

        private static void Exercise2_8(List<Book> books) {
            int count = 1 ;
            foreach (var n in books) {
                Console.WriteLine(count++ + "冊目：" + n.Title);
            }
        }

        /******************************/
        class Book {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }
    }
}
