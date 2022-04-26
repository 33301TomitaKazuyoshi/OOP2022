﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメートルの単位変更クラス
    public static class FeetConverter {

        //メートルからフィートを求める(静的メソッド)
        public static double FromMeter(double meter) {
            return meter / 0.3048;
        }
        //フィートからメートルを求める(静的メソッド)
        public static double ToMeter(int feet) {
            return feet * 0.3048;
        }
    }
}
