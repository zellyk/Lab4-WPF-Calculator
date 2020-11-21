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

        string operation = " ";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void number_Click(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;

            // int.TryParse(b.Content.ToString(), out int numPressed);

            if (txt_display.Text.ToString().Equals("0"))
            {
                txt_display.Text = b.Content.ToString();
            }
            else 
            {
                txt_display.Text += b.Content.ToString();
            }
        }

        private void operation_Click(object sender, RoutedEventArgs e)
        {

            Button b = (Button)sender;

            // int.TryParse(b.Content.ToString(), out int numPressed);

            number1 = double.Parse(txt_display.Text);

            operation = b.Content.ToString();
            txt_display.Text = "0";

        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;

            number2 = double.Parse(txt_display.Text);

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
                    if(number2 == 0)
                    {
                      break; 
                    }
                    txt_display.Text = (number1 / number2).ToString();
                    break;


                string operation = "";
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

            string input = txt_display.Text;
            List<Char> textPosNeg = txt_display.Text.ToList();
            string pat = @"-[0-9]+";
            string pat2 = @"-[0-9]+\.[0-9]+";

            if (System.Text.RegularExpressions.Regex.IsMatch(input, pat) || System.Text.RegularExpressions.Regex.IsMatch(input, pat2))
            {
                List<Char> positiveValue;
                positiveValue = textPosNeg.Where(x => !x.Equals('-')).ToList();
                string newValue = new string(positiveValue.ToArray());
                txt_display.Text = newValue;
                return;
            }

            string negativeValue;
            negativeValue = "-" + txt_display.Text;
            txt_display.Text = negativeValue;
        

    } 

        private void btn_decimal_Click(object sender, RoutedEventArgs e)
        {
            if (!txt_display.Text.ToString().Contains("."))
            {
                txt_display.Text += ".";
            }
        }
        private void btn_perc_Click(object sender, RoutedEventArgs e)
        {
            double percentValue;

            if (number2 == 0)
            {
                percentValue = double.Parse(txt_display.Text) / 100;
                txt_display.Text = percentValue.ToString();
                return;
            }
            else
            {
                percentValue = number2 * (double.Parse(txt_display.Text) / 100);
                txt_display.Text = percentValue.ToString();
            }
            

        }
    }
}
