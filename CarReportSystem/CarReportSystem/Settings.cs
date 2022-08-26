﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CarReportSystem {

    //設定情報
    [Serializable]
    public class Settings {

        private static Settings settings;

        //コンストラクタ
        private Settings() { }
        public static Settings getInstance() {
            if (settings == null) {
                settings = new Settings();
            }
            return settings;
        }
        public int MainFormColor { get; set; }
    }
}
