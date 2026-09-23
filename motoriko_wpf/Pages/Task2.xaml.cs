using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace motoriko_wpf.Pages
{
    public partial class Task2 : Page
    {
        public Task2() { InitializeComponent(); }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите строку!");
                return;
            }

            string vowels = "аеёиоуыэюяАЕЁИОУЫЭЮЯ";
            int count = input.Count(c => vowels.Contains(c));
            txtResult.Text = $"Количество гласных букв: {count}";
        }
    }
}