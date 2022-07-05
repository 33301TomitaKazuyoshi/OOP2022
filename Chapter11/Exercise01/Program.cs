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

            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
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
            var ballsports = xdoc.Root.Elements().Select(x => new {
                Firstplayed = x.Element("firstplayed").Value,
                Name = x.Element("name").Attribute("kanji").Value
            }).OrderBy(x => int.Parse(x.Firstplayed));
            foreach (var ballsport in ballsports) {
                Console.WriteLine("{0}({1})",ballsport.Name,ballsport.Firstplayed);
            }
        }

        private static void Exercise1_3(string file) {
            var xdoc = XDocument.Load(file);
            var ballsport = xdoc.Root.Elements()
                .OrderByDescending(x => (int)x.Element("teammembers")).First();

            Console.WriteLine("{0} {1}人", ballsport.Element("name").Value
                                         , ballsport.Element("teammembers").Value);
        }

        private static void Exercise1_4(string file, string newfile) {
            var element = new XElement(newfile,
                    new XElement("name", "サッカー", new XAttribute("kanji", "蹴球")),
                    new XElement("teammembers", 11),
                    new XElement("firstplayed", 1863)
                );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            xdoc.Save(newfile);

        }
    }
}
