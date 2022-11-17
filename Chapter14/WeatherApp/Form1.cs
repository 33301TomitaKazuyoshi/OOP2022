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
        private void cbHokkaido_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbHokkaido.Text) {
                case "宗谷地方":
                    areaCode = 011000;
                    lbAreaName.Text = "宗谷地方";
                    break;
                case "上川・留萌地方":
                    areaCode = 012000;
                    lbAreaName.Text = "上川・留萌地方";
                    break;
                case "網走・北見・紋別地方":
                    areaCode = 013000;
                    lbAreaName.Text = "網走・北見・紋別地方";
                    break;
                case "十勝地方":
                    areaCode = 014030;
                    lbAreaName.Text = "十勝地方";
                    break;
                case "釧路・根室地方":
                    areaCode = 014100;
                    lbAreaName.Text = "釧路・根室地方";
                    break;
                case "胆振・日高地方":
                    areaCode = 015000;
                    lbAreaName.Text = "胆振・日高地方";
                    break;
                case "石狩・空知・後志地方":
                    areaCode = 016000;
                    lbAreaName.Text = "石狩・空知・後志地方";
                    break;
                case "渡島・檜山地方":
                    areaCode = 017000;
                    lbAreaName.Text = "渡島・檜山地方";
                    break;
            }
            WeatherDataGet(areaCode);
        }

        private void cbTohoku_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbTohoku.Text) {
                case "青森県":
                    areaCode = 020000;
                    lbAreaName.Text = "青森県";
                    break;
                case "岩手県":
                    areaCode = 030000;
                    lbAreaName.Text = "岩手県";
                    break;
                case "宮城県":
                    areaCode = 040000;
                    lbAreaName.Text = "宮城県";
                    break;
                case "秋田県":
                    areaCode = 050000;
                    lbAreaName.Text = "秋田県";
                    break;
                case "山形県":
                    areaCode = 060000;
                    lbAreaName.Text = "山形県";
                    break;
                case "福島県":
                    areaCode = 070000;
                    lbAreaName.Text = "福島県";
                    break;
            }
            WeatherDataGet(areaCode);
        }

        private void cbKanto_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbKanto.Text) {
                case "茨城県":
                    areaCode = 080000;
                    lbAreaName.Text = "茨城県";
                    break;
                case "栃木県":
                    areaCode = 090000;
                    lbAreaName.Text = "栃木県";
                    break;
                case "群馬県":
                    areaCode = 100000;
                    lbAreaName.Text = "群馬県";
                    break;
                case "埼玉県":
                    areaCode = 110000;
                    lbAreaName.Text = "埼玉県";
                    break;
                case "千葉県":
                    areaCode = 120000;
                    lbAreaName.Text = "千葉県";
                    break;
                case "東京都":
                    areaCode = 130000;
                    lbAreaName.Text = "東京都";
                    break;
                case "神奈川県":
                    areaCode = 140000;
                    lbAreaName.Text = "神奈川県";
                    break;
            }
            WeatherDataGet(areaCode);
        }

        private void cbTyubu_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbKinki_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbChugokuShikoku_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void cbKyushu_SelectedIndexChanged(object sender, EventArgs e) {

        }

        public void WeatherDataGet(int areacode) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            
            if (areacode <= 99999) {
                var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/0{areacode}.json");
                WeatherData(dString);
            } else {
                var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{areacode}.json");
                WeatherData(dString);
            }
            //var wString = wc.DownloadString("");
            //var wJson = JsonConvert.DeserializeObject<Rootobject>(wString);
            //pbWeatherImage.Image = wJson
        }

        public void WeatherData(string dString) {
            var dJson = JsonConvert.DeserializeObject<Rootobject>(dString);
            lbPublishingOffice.Text = dJson.publishingOffice;
            lbReportDatetime.Text = dJson.reportDatetime.ToString();
            tbWeatherInfo.Text = dJson.text;
        }

        private void label4_Click(object sender, EventArgs e) {

        }

        
    }
}
