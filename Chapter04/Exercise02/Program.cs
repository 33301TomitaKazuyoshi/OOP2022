using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {

            var nums = new int[] {
                4,
                5,
                6,
                7,
                8,
            };



            //4.2.1
            var ymCollection = new YearMonth[] { 
                new YearMonth(1999,10),
                new YearMonth(2002,11),
                new YearMonth(2200,6),
                new YearMonth(1888,4),
                new YearMonth(2010,12),  //最後のカンマは付けておく（P103）
            };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("-------------");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("-------------");

            //4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("-------------");

            //4.2.6
            Exercise2_6(ymCollection);
            Console.WriteLine("-------------");
        }

        

        //4.2.3

        //最初に見つかった21世紀のオブジェクトを返す
        //見つからなかった場合はnullを返す
        static YearMonth FindFirst21C(YearMonth[] yms) {

            foreach (var ym in yms) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
            
        }

        private static void Exercise2_2(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise2_4(YearMonth[] ymCollection) {
            var yearmonth = FindFirst21C(ymCollection);
            if (yearmonth != null) {
                Console.WriteLine(yearmonth);
            } else { 
                Console.WriteLine("21世紀のデータはありません");
            }
        }

        private static void Exercise2_5(YearMonth[] ymCollection) {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array) {
                Console.WriteLine(ym);
            }
        }

        private static void Exercise2_6(YearMonth[] ymCollection) {

            //①月を昇順に　
            foreach (var ym in ymCollection.OrderBy(ym => ym.Month)){
                Console.WriteLine(ym);
            }

            Console.WriteLine("-------------");

            //②偶数年のみ昇順に　
            foreach (var ym in ymCollection.Where(ym => ym.Year %2 == 0).OrderBy(ym => ym.Year)){
                Console.WriteLine(ym);
            }

            Console.WriteLine("-------------");

            //③閏年のみ昇順に　
            foreach (var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year))){
                Console.WriteLine(ym);
            }

            Console.WriteLine("-------------");

            //④すべての年から12月に一番近い月を
            var data = ymCollection.Max(ym => ym.Month);
                    Console.WriteLine(data);
        }
    }
}
