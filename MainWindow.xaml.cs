﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var a = double.Parse(FirstNumber.Text);
            var b = double.Parse(SecondNumber.Text);
            var c = a + b;
            Result.Text = c.ToString();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var a = double.Parse(FirstNumber.Text);
            var b = double.Parse(SecondNumber.Text);
            var c = a - b;
            Result.Text = c.ToString();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        { 
            var a = double.Parse(FirstNumber.Text);
            var b = double.Parse(SecondNumber.Text);
            var c = a * b;
            Result.Text = c.ToString();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var a = double.Parse(FirstNumber.Text);
            var b = double.Parse(SecondNumber.Text);
            var c = a / b;
            Result.Text = c.ToString();
        }
    }
}