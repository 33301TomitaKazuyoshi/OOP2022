using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGame {
    public partial class Form1 : Form {
        private decimal randomNum = new Random().Next(minValue: 1, maxValue: 5);

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void input_Click(object sender, EventArgs e) {

            if (randomNum == Number.Value) {
                labelAns.Text = "正解！";
                ssMessage.Text = "〇";
            } else if (randomNum > Number.Value) {
                labelAns.Text = "";
                ssMessage.Text = Number.Value + "より大きいです。";
            } else {
                labelAns.Text = "";
                ssMessage.Text = Number.Value + "より小さいです。";
            }
        }
    }
}
