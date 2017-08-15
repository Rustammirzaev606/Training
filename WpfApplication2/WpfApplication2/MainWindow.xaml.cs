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

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Shirts shirtsCall = new Shirts();
        Hats hatsCall = new Hats();
        shoes shoesCall = new shoes();
        Pants pantsCall = new Pants();
        public MainWindow()
        {
            
            
            InitializeComponent();
        }

        private void btnHats_Click(object sender, RoutedEventArgs e)
        {
            
            hatsCall.ShowDialog();
        }

        private void btnShoes_Click(object sender, RoutedEventArgs e)
        {
            
            shoesCall.ShowDialog();
        }

        private void btnPants_Click(object sender, RoutedEventArgs e)
        {
            
            pantsCall.ShowDialog();
        }

        private void btnShirt_Click(object sender, RoutedEventArgs e)
        {
            
            shirtsCall.ShowDialog();
        }
    }
}
