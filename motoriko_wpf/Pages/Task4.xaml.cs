using System;
using System.Windows;
using System.Windows.Controls;

namespace motoriko_wpf.Pages
{
    public partial class Task4 : Page
    {
        private int[] array;
        public Task4() { InitializeComponent(); }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtSize.Text, out int n) || n < 5)
            {
                MessageBox.Show("Введите размер массива не менее 5!");
                return;
            }

            Random rnd = new Random();
            array = new int[n];
            for (int i = 0; i < n; i++) array[i] = rnd.Next(-50, 51);

            txtOriginal.Text = string.Join(" ", array);
            txtResult.Text = "";
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (array == null || array.Length < 5)
            {
                MessageBox.Show("Сначала сгенерируйте массив (N ≥ 5)!");
                return;
            }

            int[] result = (int[])array.Clone();
            int temp = result[2];
            result[2] = result[4];
            result[4] = temp;

            txtResult.Text = string.Join(" ", result);
        }
    }
}