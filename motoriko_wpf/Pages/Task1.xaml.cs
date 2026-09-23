using System.Windows;
using System.Windows.Controls;

namespace motoriko_wpf.Pages
{
    public partial class Task1 : Page
    {
        public Task1() { InitializeComponent(); }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtInput.Text, out int number) || number < 1 || number > 9999)
            {
                MessageBox.Show("Введите целое число от 1 до 9999");
                return;
            }

            string parity = (number % 2 == 0) ? "чётное" : "нечётное";
            string digits;
            if (number < 10) digits = "однозначное";
            else if (number < 100) digits = "двузначное";
            else if (number < 1000) digits = "трёхзначное";
            else digits = "четырёхзначное";

            txtResult.Text = $"{parity} {digits} число";
        }
    }
}