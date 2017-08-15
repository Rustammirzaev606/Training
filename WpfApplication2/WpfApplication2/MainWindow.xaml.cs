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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnHats_Click(object sender, RoutedEventArgs e)
        {
            Hats hatsCall = new Hats();
            hatsCall.ShowDialog();
        }

        private void btnShoes_Click(object sender, RoutedEventArgs e)
        {
            shoes shoesCall = new shoes();
            shoesCall.ShowDialog();
        }

        private void btnPants_Click(object sender, RoutedEventArgs e)
        {
            Pants pantsCall = new Pants();
            pantsCall.ShowDialog();
        }

        private void btnShirt_Click(object sender, RoutedEventArgs e)
        {
            Shirts shirtsCall = new Shirts();
            shirtsCall.ShowDialog();
        }
    }
}
