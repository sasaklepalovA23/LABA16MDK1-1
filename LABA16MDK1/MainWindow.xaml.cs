using LABA16MDK1.PAGE;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LABA16MDK1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void GoTask1(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Task1Page());
        private void GoTask2(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Task2Page());
        private void GoTask3(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Task3Page());
        private void GoTask4(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Task4Page());
        private void GoTask5(object sender, RoutedEventArgs e) => MainFrame.Navigate(new Task5Page());
    }
}
    