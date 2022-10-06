using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2() {
            var max = Library.Books.Max(x=>x.Price);
            var book = Library.Books.First(b => b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3() {
            var groups = Library.Books
                .GroupBy(b => b.PublishedYear)
                .OrderBy(g => g.Key);
            var count = Library.Books
                .GroupBy(b => b.PublishedYear)
                .Count();

            foreach (var g in groups) {
                Console.Write($"{g.Key}年 ");
                Console.WriteLine($"{g.Count()}冊");
            }
        }

        private static void Exercise1_4() {
            var selected = Library.Books
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price).Join(Library.Categories,  //結合する2番目のシーケンス
                      book => book.CategoryId,  //対象シーケンスの結合キー
                      category => category.Id,  //２番目のシーケンスの結合キー
                      (book, category) => new {
                          Title = book.Title,
                          Category = category.Name,
                          PublishedYear = book.PublishedYear,
                          Price = book.Price
                      }
                );
            foreach (var book in selected) {
                Console.WriteLine($"{book.PublishedYear}年　{book.Title} ({book.Category})");
            }

        }

        private static void Exercise1_5() {
            var selected = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,  //結合する2番目のシーケンス
                      book => book.CategoryId,  //対象シーケンスの結合キー
                      category => category.Id,  //２番目のシーケンスの結合キー
                      (book, category) => category.Name)
                .Distinct()
                      ;
            foreach (var book in selected) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {
        }

        private static void Exercise1_7() {

        }

    

        private static void Exercise1_8() {
        }
    }
}
