using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace motoriko_wpf.Pages
{
    public partial class Task5 : Page
    {
        private int[,] matrix;
        public Task5() { InitializeComponent(); }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtRows.Text, out int n) || n <= 0 ||
                !int.TryParse(txtCols.Text, out int m) || m <= 0)
            {
                MessageBox.Show("Введите корректные размеры массива!");
                return;
            }

            Random rnd = new Random();
            matrix = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    matrix[i, j] = rnd.Next(-10, 11);

            txtOriginal.Text = MatrixToString(matrix);
            txtResult.Text = "";
        }

        private void btnSort_Click(object sender, RoutedEventArgs e)
        {
            if (matrix == null)
            {
                MessageBox.Show("Сначала сгенерируйте массив!");
                return;
            }

            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[] flat = new int[n * m];
            int k = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    flat[k++] = matrix[i, j];

            int min = flat.Min();
            int max = flat.Max();

            int[] asc = (int[])flat.Clone(); Array.Sort(asc);
            int[] desc = (int[])flat.Clone(); Array.Sort(desc); Array.Reverse(desc);

            var sb = new StringBuilder();
            sb.AppendLine("По возрастанию:");
            sb.AppendLine(ArrayToMatrixString(asc, n, m));
            sb.AppendLine("По убыванию:");
            sb.AppendLine(ArrayToMatrixString(desc, n, m));
            sb.AppendLine($"Минимум: {min}");
            sb.AppendLine($"Максимум: {max}");

            txtResult.Text = sb.ToString();
        }

        private string MatrixToString(int[,] mat)
        {
            int n = mat.GetLength(0), m = mat.GetLength(1);
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) sb.Append($"{mat[i, j],5}");
                sb.AppendLine();
            }
            return sb.ToString();
        }

        private string ArrayToMatrixString(int[] arr, int n, int m)
        {
            var sb = new StringBuilder();
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++) sb.Append($"{arr[k++],5}");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}