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

namespace _008_solution2
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            double NumOne = 0, NumTwo = 0, Sum = 0;
            NumOne = Convert.ToDouble(textBox1.Text);
            NumTwo = Convert.ToDouble(textBox2.Text);
            Sum = NumOne + NumTwo;
            labelSum.Content = Sum;


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            double NumOne = 0, NumTwo = 0, Sum = 0;
            NumOne = Convert.ToDouble(textBox1.Text);
            NumTwo = Convert.ToDouble(textBox2.Text);
            Sum = NumOne - NumTwo;
            labelSum.Content = Sum;



        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            double NumOne = 0, NumTwo = 0, Sum = 0;
            NumOne = Convert.ToDouble(textBox1.Text);
            NumTwo = Convert.ToDouble(textBox2.Text);
            Sum = NumOne % NumTwo;
            labelSum.Content = Sum;

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            double NumOne = 0, NumTwo = 0, Sum = 0;
            NumOne = Convert.ToDouble(textBox1.Text);
            NumTwo = Convert.ToDouble(textBox2.Text);
            Sum = NumOne * NumTwo;
            labelSum.Content = Sum;

        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            double NumOne = 0, NumTwo = 0, Sum = 0;
            NumOne = Convert.ToDouble(textBox1.Text);
            NumTwo = Convert.ToDouble(textBox2.Text);
            Sum = NumOne / NumTwo;
            labelSum.Content = Sum;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
