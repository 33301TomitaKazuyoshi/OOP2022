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
            switch (cbTyubu.Text) {
                case "新潟県":
                    areaCode = 150000;
                    lbAreaName.Text = "新潟県";
                    break;
                case "富山県":
                    areaCode = 160000;
                    lbAreaName.Text = "富山県";
                    break;
                case "石川県":
                    areaCode = 170000;
                    lbAreaName.Text = "石川県";
                    break;
                case "福井県":
                    areaCode = 180000;
                    lbAreaName.Text = "福井県";
                    break;
                case "山梨県":
                    areaCode = 190000;
                    lbAreaName.Text = "山梨県";
                    break;
                case "長野県":
                    areaCode = 200000;
                    lbAreaName.Text = "長野県";
                    break;
                case "岐阜県":
                    areaCode = 210000;
                    lbAreaName.Text = "岐阜県";
                    break;
                case "静岡県":
                    areaCode = 220000;
                    lbAreaName.Text = "静岡県";
                    break;
                case "愛知県":
                    areaCode = 230000;
                    lbAreaName.Text = "愛知県";
                    break;

                
            }
            WeatherDataGet(areaCode);
        }

        private void cbKinki_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbKinki.Text) {
                case "三重県":
                    areaCode = 240000;
                    lbAreaName.Text = "三重県";
                    break;
                case "滋賀県":
                    areaCode = 250000;
                    lbAreaName.Text = "滋賀県";
                    break;
                case "京都府":
                    areaCode = 260000;
                    lbAreaName.Text = "京都府";
                    break;
                case "大阪府":
                    areaCode = 270000;
                    lbAreaName.Text = "大阪府";
                    break;
                case "兵庫県":
                    areaCode = 280000;
                    lbAreaName.Text = "兵庫県";
                    break;
                case "奈良県":
                    areaCode = 290000;
                    lbAreaName.Text = "奈良県";
                    break;
                case "和歌山県":
                    areaCode = 300000;
                    lbAreaName.Text = "和歌山県";
                    break;
            }
            WeatherDataGet(areaCode);
        }

        private void cbChugokuShikoku_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbChugokuShikoku.Text) {
                case "鳥取県":
                    areaCode = 310000;
                    lbAreaName.Text = "鳥取県";
                    break;
                case "島根県":
                    areaCode = 320000;
                    lbAreaName.Text = "島根県";
                    break;
                case "岡山県":
                    areaCode = 330000;
                    lbAreaName.Text = "岡山県";
                    break;
                case "広島県":
                    areaCode = 340000;
                    lbAreaName.Text = "広島県";
                    break;
                case "山口県":
                    areaCode = 350000;
                    lbAreaName.Text = "山口県";
                    break;
                case "徳島県":
                    areaCode = 360000;
                    lbAreaName.Text = "奈良県";
                    break;
                case "香川県":
                    areaCode = 370000;
                    lbAreaName.Text = "香川県";
                    break;
                case "愛媛県":
                    areaCode = 380000;
                    lbAreaName.Text = "愛媛県";
                    break;
                case "高知県":
                    areaCode = 390000;
                    lbAreaName.Text = "高知県";
                    break;
            }
            WeatherDataGet(areaCode);
        }

        private void cbKyushu_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbKyushu.Text) {
                case "福岡県":
                    areaCode = 400000;
                    lbAreaName.Text = "福岡県";
                    break;
                case "佐賀県":
                    areaCode = 410000;
                    lbAreaName.Text = "佐賀県";
                    break;
                case "長崎県":
                    areaCode = 420000;
                    lbAreaName.Text = "長崎県";
                    break;
                case "熊本県":
                    areaCode = 430000;
                    lbAreaName.Text = "熊本県";
                    break;
                case "大分県":
                    areaCode = 440000;
                    lbAreaName.Text = "大分県";
                    break;
                case "宮崎県":
                    areaCode = 450000;
                    lbAreaName.Text = "宮崎県";
                    break;
                case "鹿児島県":
                    areaCode = 460100;
                    lbAreaName.Text = "鹿児島県";
                    break;
            }
            WeatherDataGet(areaCode);
        }

        private void cbOkinawa_SelectedIndexChanged(object sender, EventArgs e) {
            switch (cbOkinawa.Text) {
                case "沖縄本島地方":
                    areaCode = 471000;
                    lbAreaName.Text = "沖縄本島地方";
                    break;
                case "大東島地方":
                    areaCode = 472000;
                    lbAreaName.Text = "大東島地方";
                    break;
                case "宮古島地方":
                    areaCode = 473000;
                    lbAreaName.Text = "宮古島地方";
                    break;
                case "八重山地方":
                    areaCode = 474000;
                    lbAreaName.Text = "八重山地方";
                    break;
            }
            WeatherDataGet(areaCode);
        }

        public void WeatherDataGet(int areacode) {
            var wc = new WebClient() {
                Encoding = Encoding.UTF8
            };
            
            if (areacode <= 99999) {
                var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/0{areacode}.json");
                //var wString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/forecast/0{areacode}.json");
                //pbWeatherImage.Image = loadImageFromURL($"https://www.jma.go.jp/bosai/forecast/img/{JsonConvert.DeserializeObject<Area4>(wString).weatherCodes}.svg");
                WeatherDataD(dString);
                //WeatherDataW(wString);
            } else {
                var dString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{areacode}.json");
                //var wString = wc.DownloadString($"https://www.jma.go.jp/bosai/forecast/data/forecast/{areacode}.json");
                //pbWeatherImage.Image = loadImageFromURL ($"https://www.jma.go.jp/bosai/forecast/img/{JsonConvert.DeserializeObject<Area4>(wString).weatherCodes}.svg");
                WeatherDataD(dString);
                //WeatherDataW(wString);
            }
            
        }
        

        public void WeatherDataD(string dString) {
            var dJson = JsonConvert.DeserializeObject<Rootobject>(dString);
            lbPublishingOffice.Text = dJson.publishingOffice;
            lbReportDatetime.Text = dJson.reportDatetime.ToString();
            tbWeatherInfo.Text = dJson.text;
        }
        public void WeatherDataW(string wString) {
            var wJson = JsonConvert.DeserializeObject<Area4>(wString);



        }

    }
}
