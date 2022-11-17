using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        public int areaCode;
        private void Form1_Load(object sender, EventArgs e) {
            
        }

        private void cbTohoku_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbKanto_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbKanto.Text) {
                case "群馬県":
                    areaCode = 100000;
                    break;
                case "栃木県":
                    areaCode = 090000;
                    break;
                case "茨城県":
                    areaCode = 080000;
                    break;
                case "埼玉県":
                    areaCode = 110000;
                    break;
                case "東京都":
                    areaCode = 130000;
                    break;
                case "神奈川県":
                    areaCode = 140000;
                    break;
                case "千葉県":
                    areaCode = 100000;
                    break;
            }
        }

        private void cbTyubu_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbKinki_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbChugokuShikoku_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbKyushu_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}
