using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        List<MyColor> stockMyColor = new List<MyColor>();

        MyColor myColor = new MyColor();

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }
        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            colorLabel.Background = new SolidColorBrush( Color.FromRgb((byte)RedSlider.Value, (byte)GreenSlider.Value, (byte)BlueSlider.Value));
            
        }

        private void Border_Loaded(object sender, RoutedEventArgs e) {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var myColor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = myColor.Color;
            var name = myColor.Name;

            stockMyColor.Add(new MyColor() {
                Name = name,
                Color = color,
            });

            colorLabel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));
            RedSlider.Value = color.R;
            GreenSlider.Value = color.G;
            BlueSlider.Value = color.B;
        }

        private void colorButton_Click(object sender, RoutedEventArgs e) {
            MyColor myColor = new MyColor();
            var r = byte.Parse(rValue.Text);
            var g = byte.Parse(gValue.Text);
            var b = byte.Parse(bValue.Text);

            myColor.Color = Color.FromRgb(r, g, b);

            var colorName = ((IEnumerable<MyColor>)DataContext)
                .Where(c => c.Color.R == myColor.Color.R &&
                            c.Color.G == myColor.Color.G && 
                            c.Color.B == myColor.Color.B)
                            .FirstOrDefault();

            stockList.Items.Add(colorName?.Name ?? $"R：{RedSlider.Value} G：{GreenSlider.Value} B：{BlueSlider.Value}");
            stockMyColor.Add(myColor);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            int index = stockList.SelectedIndex;
            RedSlider.Value = stockMyColor[index].Color.R;
            GreenSlider.Value = stockMyColor[index].Color.G;
            BlueSlider.Value = stockMyColor[index].Color.B;
        }
    }



    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
