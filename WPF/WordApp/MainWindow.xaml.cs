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

namespace WordApp {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btExit_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void btCreate_Click(object sender, RoutedEventArgs e) {
            var creater = new Creater();
            frame.Navigate(creater);
        }

        private void btTest_Click(object sender, RoutedEventArgs e) {
            var fSelect = new FolderSelect();
            frame.Navigate(fSelect);
        }
    }
}
