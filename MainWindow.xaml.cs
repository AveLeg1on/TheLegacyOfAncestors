
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
            entered.GetCatit1(value);
            double.TryParse(two.Text, out double value2);
            entered.GetCatit2(value2);

            //entered.HypotenuseCalculation()
            Jumbo.Text=$"Гипотинуза:{entered.HypotenuseCalculation()}"/*,Площадь:{entered.Two}*/;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

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
