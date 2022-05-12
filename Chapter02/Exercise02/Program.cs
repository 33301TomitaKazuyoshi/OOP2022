using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        //コマンドライン引数
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintInchToMeterList(1, 10);
            }
            else {
                //メーターからフィートへの対応表を出力
                PrintMeterToInchList(1, 10);
            }
        }

        //インチからメートルへの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {
            //インスタンス（インチとメートルの単位変更クラス）
            for (int inch = start; inch <= stop; inch++) {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} inch = {1:0.0000} m", inch, meter);
            }
        }

        //メーターからインチへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {
            //インスタンス（インチとメートルの単位変更クラス）

            for (double meter = start; meter <= stop; meter++) {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} inch", meter, inch);
            }
        }
    }
}
