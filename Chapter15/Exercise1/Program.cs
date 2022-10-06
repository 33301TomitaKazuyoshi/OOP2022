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
            var query = Library.Books
                .GroupBy(b => b.PublishedYear);

            foreach(var item in query.OrderBy(b=>b.Key)) {
                Console.WriteLine("{0}年 {1}冊 " ,item.Key,item.Count());
            }
        }

        private static void Exercise1_4() {
            var selected = Library.Books
                .Join(Library.Categories,  //結合する2番目のシーケンス
                      book => book.CategoryId,  //対象シーケンスの結合キー
                      category => category.Id,  //２番目のシーケンスの結合キー
                      (book, category) => new {
                          Title = book.Title,
                          Category = category.Name,
                          PublishedYear = book.PublishedYear,
                          Price = book.Price
                      })
                .OrderByDescending(b => b.PublishedYear)
                .ThenByDescending(b => b.Price);
            foreach (var book in selected) {
                Console.WriteLine($"{book.PublishedYear}年 {book.Price}円 {book.Title} ({book.Category})");
            }

        }

        private static void Exercise1_5() {
            var query = Library.Books
                .Where(b => b.PublishedYear == 2016)
                .Join(Library.Categories,  //結合する2番目のシーケンス
                      book => book.CategoryId,  //対象シーケンスの結合キー
                      category => category.Id,  //２番目のシーケンスの結合キー
                      (book, category) => category.Name)
                .Distinct()
                      ;
            foreach (var book in query) {
                Console.WriteLine(book);
            }
        }

        private static void Exercise1_6() {
            
        }

        private static void Exercise1_7() {
            var groups = Library.Books
               .Where(b=>b.CategoryId == 1)
               .GroupBy(b => b.PublishedYear)
               .OrderBy(g => g.Key);

            foreach (var g in groups) {
                Console.WriteLine($"#{g.Key}年");
                foreach (var book in g) {
                    var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                    Console.WriteLine($" {book.Title}");

                }
            }
        }

    

        private static void Exercise1_8() {
            var groups = Library.Categories
                         .GroupJoin(Library.Books,
                         c => c.Id,
                         b => b.CategoryId,
                         (c, books) => new {
                             Category = c.Name,
                             Count = books.Count()
                         });
            foreach (var obj in groups.Where(c=>c.Count >= 4)) {

                Console.WriteLine(obj.Category);
            }
        }
    }
}
