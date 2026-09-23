using System;
using System.Windows;
using System.Windows.Controls;

namespace motoriko_wpf.Pages
{
    public partial class Task3 : Page
    {
        private int[] array;
        public Task3() { InitializeComponent(); }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtSize.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Введите корректный размер массива!");
                return;
            }

            Random rnd = new Random();
            array = new int[n];
            for (int i = 0; i < n; i++) array[i] = rnd.Next(-20, 21);

            txtOriginal.Text = string.Join(" ", array);
            txtResult.Text = "";
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив!");
                return;
            }

            int[] result = (int[])array.Clone();
            int last = result[result.Length - 1];

            for (int i = 1; i < result.Length - 1; i++)
                if (result[i] % 2 == 0) result[i] += last;

            txtResult.Text = string.Join(" ", result);
        }
    }
}