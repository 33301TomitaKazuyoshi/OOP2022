﻿using System;
using System.Collections.Generic;
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

        public List<MyColor> stockMyColor;

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

            colorLabel.Background = new SolidColorBrush(Color.FromRgb(color.R, color.G, color.B));
            RedSlider.Value = color.R;
            GreenSlider.Value = color.G;
            BlueSlider.Value = color.B;
        }

        private void colorButton_Click(object sender, RoutedEventArgs e) {
            //stockMyColor.Add();
            foreach (var n in stockMyColor) {
                stockList.Items.Add($"R：{n.ToString()} G：{n.ToString()} B：{n.ToString()}");
            }
        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
