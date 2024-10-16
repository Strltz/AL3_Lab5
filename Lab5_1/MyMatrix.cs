using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1
{
    public class MyMatrix
    {
        private int[,] matrix;

        public MyMatrix(int m, int n, int min_value, int max_value) // m - кол-во строк,
                                                                    // n - кол-во столбцов
        {
            int[,] new_matrix = new int[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    new_matrix[i, j] =
                        RandomNumberGenerator.GetInt32(min_value, max_value);
                }
            }
            matrix = new_matrix;
        }

        public MyMatrix(int[,] mat) // конструктор (создание экземпляра по
                                    // передаваемой матрице(двумерному массиву))
        {
            matrix = mat;
        }

        public void Fill(int min_value, int max_value) // перезаполнение
        {
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); ++j)
                {
                    matrix[i, j] =
                        RandomNumberGenerator.GetInt32(min_value, max_value);
                }
            }
        }

        public void ChangeSize(int new_n, int new_m, int min_value,
            int max_value)
        {
            int current_n = matrix.GetLength(0);
            int current_m = matrix.GetLength(1);
            int[,] new_matrix = new int[new_n, new_m];

            for (int i = 0; i < Math.Min(current_n, new_n); ++i)
            {
                for (int j = 0; j < Math.Min(current_m, new_m); ++j) // копирование основной
                                                                     // части матрицы
                {
                    new_matrix[i, j] = matrix[i, j];
                }
            }

            if (new_n > current_n)
            {
                for (int i = current_n; i < new_n; ++i) // заполнение только
                                                        // нижней часты матрицы
                {
                    for (int j = 0; j < current_m; ++j)
                    {
                        new_matrix[i, j] = 
                            RandomNumberGenerator.GetInt32(min_value, max_value);
                    }
                }
                if (new_m > current_m)
                {
                    for(int i = 0; i < new_n; ++i)
                    {
                        for(int j = current_m; j < new_m; ++j) // заполнение правой
                                                               // части матрицы и уголка
                        {
                            new_matrix[i, j] =
                                RandomNumberGenerator.GetInt32(min_value, max_value);
                        }
                    }
                }
            }
            else if (new_m < current_m)
            {
                for (int i = 0; i < new_n; ++i) // заполнение только
                                                        // нижней часты матрицы
                {
                    for (int j = current_m; j < new_m; ++j)
                    {
                        new_matrix[i, j] =
                            RandomNumberGenerator.GetInt32(min_value, max_value);
                    }
                }
            }
            matrix = new_matrix;
        }

        public void ShowPartialy(int first_line, int first_column,
            int last_line, int last_column)
        {
            for(int i = first_line - 1; i < last_line; ++i)
            {
                for(int j = first_column - 1; j < last_column; ++j)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Show() // метод вывода всей матрицы на экран
        {
            if (this == null) { return; }
            int number_of_lines = matrix.GetLength(0);
            int number_of_columns = matrix.GetLength(1);
            for (int i = 0; i < number_of_lines; ++i)
            {
                for (int j = 0; j < number_of_columns; ++j)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int index_line, int index_column] // индексатор
        {
            get
            {
                return matrix[index_line - 1, index_column - 1];
            }
            set
            {
                matrix[index_line - 1, index_column - 1] = value;
            }
        }

    }
}
