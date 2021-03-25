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

namespace Repetition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            
            if(Text1.Text == "Stonk")
            {
                Text1.Text = "Text";
                Knapp2.Content = "Stonk";
            }
            else
            {
                Text1.Text = "Stonk";
                Knapp2.Content = "Text";
            }
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            if (Text1.Text == "Text")
            {
                Text1.Text = "kaka";
                Knapp2.Content = "Banan";
            }
            else
            {
                Text1.Text = "Stonk";
                Knapp2.Content = "kaka";
            }
        }
    }
}
