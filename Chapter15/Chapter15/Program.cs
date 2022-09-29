using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args) {
            var price = Library.Books.Where(b=>b.CategoryId == 1).Max(b=>b.Price);
            var query1 = Library.Books.Select(b => b.PublishedYear).Distinct().OrderBy(y => y);
            var query2 = Library.Books.OrderBy(b => b.CategoryId).ThenByDescending(b => b.PublishedYear);
            Console.WriteLine(price);
            Console.WriteLine();
            foreach (var n in query2) { 
                Console.WriteLine(n); 
            }
            
        
        
        }
    }
}
