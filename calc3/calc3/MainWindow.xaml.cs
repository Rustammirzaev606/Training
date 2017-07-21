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

namespace calc3
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

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "+";
        }

        private void btn_sub_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "-";
        }

        private void btn_mult_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "*";
        }

        private void btn_div_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + ":";
        }

        private void btn_equal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                result();
            }
            catch (Exception exc)
            {
                textBox.Text = "Error!";
            }
        }
        private void result()
        {
            String op;
            int iOp = 0;
            if (textBox.Text.Contains("+"))
            {
                iOp = textBox.Text.IndexOf("+");
            }
            else if (textBox.Text.Contains("-"))
            {
                iOp = textBox.Text.IndexOf("-");
            }
            else if (textBox.Text.Contains("*"))
            {
                iOp = textBox.Text.IndexOf("*");
            }
            else if (textBox.Text.Contains("/"))
            {
                iOp = textBox.Text.IndexOf("/");
            }
            else
            {
                //error    
            }

            op = textBox.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(textBox.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(textBox.Text.Substring(iOp + 1, textBox.Text.Length - iOp - 1));

            if (op == "+")
            {
                textBox.Text += "=" + (op1 + op2);
            }
            else if (op == "-")
            {
                textBox.Text += "=" + (op1 - op2);
            }
            else if (op == "*")
            {
                textBox.Text += "=" + (op1 * op2);
            }
            else
            {
                textBox.Text += "=" + (op1 / op2);
            }
        }

        private void btn_clear_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
        }

        private void btn_off_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
