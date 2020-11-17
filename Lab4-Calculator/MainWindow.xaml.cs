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

namespace Lab4_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double number1 = 0;
        double number2 = 0;
        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;

           // int.TryParse(b.Content.ToString(), out int numPressed);

            txt_display.Text += b.Content.ToString();

        }

        private void operation_Click(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;

            // int.TryParse(b.Content.ToString(), out int numPressed);

            number1 = int.Parse(txt_display.Text);

            operation = b.Content.ToString();
            txt_display.Text = "0";

        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            number2 = int.Parse(txt_display.Text);

            switch (operation)
            {
                case "+":
                    txt_display.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txt_display.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txt_display.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txt_display.Text = (number1 / number2).ToString();
                    break;
                case "%":
                    txt_display.Text = (number1 % number2).ToString();
                    break;

            }


        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            txt_display.Text = "0";

        }

        private void btn_positive_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
               // number1 *= -1; check for current string status -/+
                txt_display.Text = "-" + number1.ToString();
            }
            else
            {
                number2 *= -1;
                txt_display.Text = number2.ToString();
            }
        } 

        private void btn_decimal_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += .0;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 += .0;
                txt_display.Text = number2.ToString();
            }
        }
    }
}
