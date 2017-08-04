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

namespace BankApp_WPF_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double balance = 1000;
        double temp1, temp2;
        string tempStr1, tempStr2;
        public MainWindow()
        {
            
            InitializeComponent();

        }
        private void txtBoxInput_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBoxInput.Text = "";
        }


        private void txtBoxInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" CEO / GM / PRESIDENT\n RUSTAM MIRZAEV\n (216) 801 - 6162\n RustamMirzaev606@gmail.com");
        }

        private void button_Click(object sender, RoutedEventArgs e) //depo
        {
            
            tempStr1 = txtBoxInput.Text;
            double.TryParse(tempStr1, out temp1);
            if(!double.TryParse(tempStr1, out temp1))
            {
                //txtBoxInput.Text = "Error. Try again";
                MessageBox.Show("Error.Try again!");
            }
            else if (temp1 < 0)
            {
                MessageBox.Show("Please dont use negative values!");

            }
            else
            {
                balance += temp1;
                txtBoxInput.Clear();
            }
            
            Balance.Content = balance.ToString("C");

        }

        private void button1_Click(object sender, RoutedEventArgs e) //withdraw
        {
            tempStr2 = txtBoxInput.Text;
            double.TryParse(tempStr2, out temp2);
            if(!double.TryParse(tempStr2, out temp2))
            {
                //txtBoxInput.Text = "Error. Try again";
                MessageBox.Show("Error.Try again!");
            }
            else if(temp2 < 0)
            {
                MessageBox.Show("Please dont use negative numbers!");
            }
            else if(balance < temp2)
            {
                //txtBoxInput.Text = "Insufficient funds";
                MessageBox.Show("Insufficient funds");
            }
            else
            {
                balance -= temp2;
                txtBoxInput.Clear();
            }

            Balance.Content = balance.ToString("C");
        }
    }
}
