﻿using System;
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
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for Hats.xaml
    /// </summary>
    public partial class Hats : Window
    {
        public Hats()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            HatsObjects clickHat = new HatsObjects();
            clickHat.SomeHats(1);
            HatsSubtotalLabel.Content = $"TOTAL: {clickHat.Subtotal.ToString("C")}";
        }
    }
}
