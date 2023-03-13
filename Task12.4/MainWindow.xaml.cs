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

namespace Task12._4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _result;

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            _result = Convert.ToInt32(number1.Text) - Convert.ToInt32(number2.Text);
            Result.Text = Convert.ToString(_result);
        }

        private void Mul_Click(object sender, RoutedEventArgs e)
        {
            _result = Convert.ToInt32(number1.Text) * Convert.ToInt32(number2.Text);
            Result.Text = Convert.ToString(_result);
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            _result = Convert.ToInt32(number1.Text) / Convert.ToInt32(number2.Text);
            Result.Text = Convert.ToString(_result);
        }

        private void Result_TextChanged(object sender, TextChangedEventArgs e)
        {
            Result.Text = Convert.ToString(_result);
        }

        private void number1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _result = Convert.ToInt32(number1.Text) + Convert.ToInt32(number2.Text);
            Result.Text = Convert.ToString(_result);
        }
    }
}
