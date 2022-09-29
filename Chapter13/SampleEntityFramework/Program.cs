using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args) {
            //13-1
            //InsertBooks();
            //AddAuthors();
            //AddBooks();
            var books = GetAllBooks();

            //13-2
            foreach (var book in books) {
                Console.WriteLine($"{book.Title}  {book.PublishedYear}");
            }


            //13-3
            var books3 = GetMaxBooks();
            foreach (var book in books3) {
                Console.WriteLine($"{book.Title}  {book.PublishedYear}");
            }
            //13-4
            var books4 = GetObBooks();
            foreach (var book in books4) {
                Console.WriteLine($"{book.Title}  {book.PublishedYear}");
            }

            //13-5
            var authors = GetgggBooks();
            foreach (var author in authors) {
                Console.WriteLine("{0}{1:yyyy/MM}",author.Name,author.Birthday);
                foreach (var book in author.Books) {
                    Console.WriteLine("{0}{1}",book.Title,book.PublishedYear);
                }
            }

        }
        static void InsertBooks() {
            using (var db = new BooksDbContext()) {
                var book1 = new Book {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };

                db.Books.Add(book1);

                var book2 = new Book {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "男性",
                        Name = "太宰治",
                    }
                };

                db.Books.Add(book2);
                db.SaveChanges(); //データベースの更新
            }
        }


        // List 13-9
        private static void AddAuthors() {
            using (var db = new BooksDbContext()) {
                var author1 = new Author {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "F",
                    Name = "菊池寛"
                };
                db.Authors.Add(author1);
                var author2 = new Author {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "F",
                    Name = "川端康成"
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }

        // List 13-10
        private static void AddBooks() {
            using (var db = new BooksDbContext()) {
                var author1 = db.Authors.Single(a => a.Name == "夏目漱石");
                var book1 = new Book {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "川端康成");
                var book2 = new Book {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author2,
                };
                db.Books.Add(book2);
                var author3 = db.Authors.Single(a => a.Name == "菊池寛");
                var book3 = new Book {
                    Title = "真珠婦人",
                    PublishedYear = 2002,
                    Author = author3,
                };
                db.Books.Add(book3);
                var author4 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book4 = new Book {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author4,
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }
        }
        
        static IEnumerable<Book> GetAllBooks() {
            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write(sql); };
                return db.Books.Include(nameof(Author)).ToList();
            }
        }

        static IEnumerable<Book> GetBooks() {
            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write(sql); };
                return db.Books.Include(nameof(Author)).Where(book=>book.Author.Name.StartsWith("夏目")).ToList();
            }
        }
        
        static IEnumerable<Book> GetMaxBooks() {
            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write(sql); };
                return db.Books.Include(nameof(Author)).Where(b => b.Title.Length == db.Books.Max(x=>x.Title.Length)).ToList(); 
            }
        }

        static IEnumerable<Book> GetObBooks() {
            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write(sql); };
                return db.Books.Include(nameof(Author)).OrderBy(b=>b.PublishedYear).Take(3).ToList();
            }
        }
        static IEnumerable<Author> GetgggBooks() {
            using (var db = new BooksDbContext()) {
                db.Database.Log = sql => { Debug.Write(sql); };
                return db.Authors.Include(nameof(Book)).OrderByDescending(b => b.Birthday).ToList();
            }
        }

    }

}
