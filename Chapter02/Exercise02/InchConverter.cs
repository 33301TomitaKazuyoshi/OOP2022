using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public static class InchConverter {

        //定数をratioで定義
        private const double ratio = 0.0254;  //マジックナンバー
        //public static readonly double ratio = 0.0254 ⇐外部からもアクセスさせたい場合
        //メートルからインチを求める(静的メソッド)
        public static double FromMeter(double meter) {
            return meter / ratio;
        }
        //インチからメートルを求める(静的メソッド)
        public static double ToMeter(int inch) {
            return inch * ratio;
        }
    }
}

