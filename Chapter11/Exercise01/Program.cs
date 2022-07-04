using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var ballsports = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    Teammembers = (int)x.Element("teammembers"),
                                });
            foreach (var ballsport in ballsports) {
                Console.WriteLine("{0} {1}",
                                   ballsport.Name, ballsport.Teammembers);
            }
        }

        private static void Exercise1_2(string file) {
            var xdoc = XDocument.Load(file);
            var ballsports = xdoc.Root.Elements()
                                .OrderBy(x => (int)x.Element("firstplayed")
                                );
            foreach (var ballsport in ballsports) {
                var name = ballsport.Element("name");
                var firstplayed = ballsport.Element("firstplayed");
                Console.WriteLine("{0}({1})",name.Attribute("kanji")?.Value,firstplayed.Value);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var ballsport = xdoc.Root.Elements().Max(x => (int)x.Element("teammembers"));
            Console.WriteLine(ballsport.ToString());
        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement(newfile,
                    new XElement("name", "サッカー"), new XAttribute("kanji", "蹴球"),
                    new XElement("teammembers", 11),
                    new XElement("firstplayed", 1863)
                );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
        }
    }
}
