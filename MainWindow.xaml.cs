
using System;
using System.IO;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace TheLegacyOfAncestors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            one.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { RightAngled entered = new RightAngled();
            double.TryParse(one.Text, out double value);
           entered.One=value;
            double.TryParse(two.Text, out double value2);
            entered.Two = value2;

            //entered.HypotenuseCalculation()
            Jumbo.Text=$"Гипотинуза: {entered.HypotenuseCalculation()}";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RightAngled entered = new RightAngled();
            double.TryParse(one.Text, out double value);
            entered.One = value;
            double.TryParse(two.Text, out double value2);
            entered.Two = value2;
            Jumbo.Text = $"Площадь: {entered.Square()}";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            one.Text = null;
            two.Text = null;
        }
    }
}
