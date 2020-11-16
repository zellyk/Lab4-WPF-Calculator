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

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) + 1;
                txt_display.Text = number1.ToString();
            }
            else 
            {
                number2 = (number2 * 10) + 1;
                txt_display.Text = number2.ToString();
            }



        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {

            if (operation == "")
            {
                number1 = (number1 * 10) + 2;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 2;
                txt_display.Text = number2.ToString();
            }
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 3;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 3;
                txt_display.Text = number2.ToString();
            }
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 4;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 4;
                txt_display.Text = number2.ToString();
            }
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 5;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 5;
                txt_display.Text = number2.ToString();
            }
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 6;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 6;
                txt_display.Text = number2.ToString();
            }
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 7;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 1;
                txt_display.Text = number2.ToString();
            }
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 8;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 8;
                txt_display.Text = number2.ToString();
            }
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 9;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 9;
                txt_display.Text = number2.ToString();
            }
        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + 0;
                txt_display.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + 0;
                txt_display.Text = number2.ToString();
            }


        }

        private void btn_plus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txt_display.Text = "0";
        }

        private void btn_minus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txt_display.Text = "0";
        }

        private void btn_times_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txt_display.Text = "0";
        }

        private void btn_divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txt_display.Text = "0";
        }

        private void btn_mod_Click(object sender, RoutedEventArgs e)
        {
            operation = "%";
            txt_display.Text = "0";
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {

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
                number1 *= -1; 
                txt_display.Text = number1.ToString();
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
