using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Exercise01 {

    [XmlRoot("employee")]
    public class Employee {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hiredate")]
        public DateTime HireDate { get; set; }
        public override string ToString() {
            return string.Format("[id={0}, name={1}, hiredate={2}]",
                                  Id, Name, HireDate);
        }
    }

    //1-4で使う
    [DataContract(Name = "employee2")]
    public class Employee2 {
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "hireDate")]
        public DateTime HireDate { get; set; }
    }

    class Program {
        static void Main(string[] args) {
            //Exercise1_1("employee.xml");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employee.xml"));
            //Console.WriteLine();

            //Exercise1_2("employees.xml");
            //Exercise1_3("employees.xml");
            //Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile) {
            var emp = new Employee {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001,5,10)
            };
            //シリアル化
            using (var writer = XmlWriter.Create(outfile)) {
                var serializer = new XmlSerializer(emp.GetType());
                serializer.Serialize(writer, emp);
            }

            //逆シリアル化
            using (var reader = XmlReader.Create(outfile)) {
                var serializer = new XmlSerializer(typeof(Employee));
                var employee = serializer.Deserialize(reader) as Employee;
                // 以下、内容を確認するコード
                Console.WriteLine(employee);
            }
        }

        private static void Exercise1_2(string outfile) {
            var employees = new Employee[] {
               new Employee {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001,5,10)
               },
               new Employee {
                Id = 139,
                Name = "大橋 孝仁",
                HireDate = new DateTime(2004,12,1)
               },
            };

            //シリアル化
            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using (var writer = XmlWriter.Create(outfile, settings)) {
                var serializer = new DataContractSerializer(employees.GetType());
                serializer.WriteObject(writer, employees);
            }
           
        }

        private static void Exercise1_3(string v) {
            using (var reader = XmlReader.Create("employees.xml")) {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var employees = serializer.ReadObject(reader) as Employee[];
                // 以下、内容を確認するコード
                foreach (var employee in employees) {
                    Console.WriteLine(employee);
                }
            }
        }

        private static void Exercise1_4(string outfile) {
            var employees = new Employee2[] {
               new Employee2 {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001,5,10)
               },
               new Employee2 {
                Id = 139,
                Name = "大橋 孝仁",
                HireDate = new DateTime(2004,12,1)
               },
            };
            //シリアル化
            using (var stream = new FileStream(outfile, FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(employees.GetType(),new DataContractJsonSerializerSettings { 
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd")
                });
                serializer.WriteObject(stream,employees);
            }
        }
    }
}
