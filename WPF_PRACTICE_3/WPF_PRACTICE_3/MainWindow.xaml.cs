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

namespace WPF_PRACTICE_3
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

        private void btnLbl1_Click(object sender, RoutedEventArgs e)
        {
            
            string words = txtBoxLbl1.Text;
            lbl1.Content = words;

            //double number = Convert.ToDouble(txtBoxLbl1);
            //lbl1.Content = number;

            
        }

        private void btnPoop_Click(object sender, RoutedEventArgs e)
        {
            Pop_Up_Window_1 poopUp = new Pop_Up_Window_1();
            poopUp.ShowDialog();
        }
    }
}
