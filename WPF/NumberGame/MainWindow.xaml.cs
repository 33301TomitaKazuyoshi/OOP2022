using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NumberGame {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private int correctNumber = new Random().Next(25) + 1;
        private void Button_Click(object sender, RoutedEventArgs e) {
            Button bt = (Button)sender;
            var num = int.Parse(bt.Content.ToString());
            if (num == correctNumber) {
                infoDisp.Text = "〇";
                bt.Background = Brushes.Aquamarine;
            }else{
                infoDisp.Text = num < correctNumber ? "当たりより小さい" : "当たりより大きい";
                bt.Background = num < correctNumber ? Brushes.Blue : Brushes.Green;
            }
             
             
        }
    }
}
