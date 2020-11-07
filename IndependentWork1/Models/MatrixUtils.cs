using IndependentWork1.Interfaces;
using System;

namespace IndependentWork1.Models
{
    public static class MatrixUtils
    {
        public static void PrintMatrixData(this IMatrix matrix)
        {
            MatrixStatistics matrixStatistics = new MatrixStatistics(matrix);

            Console.WriteLine("Сумма элементов матрицы: " + matrixStatistics.ValuesSum);
            Console.WriteLine("Среднее значение матрицы: " + matrixStatistics.Mean);
            Console.WriteLine("Максимальное значение матрицы: " + matrixStatistics.MaxValue);
            Console.WriteLine("Количество ненулевых элементов: " + matrixStatistics.nonValuesElementsCount);
        }

        public static void PrintMatrix(this IMatrix matrix)
        {
            for (int i = 0; i < matrix.RowNumber; i++)
            {

                for (int k = 0; k < matrix.ColumnNumber; k++)
                {

                    if (matrix is SparseMatrix)
                    {
                        if (matrix[i, k] == 0)
                        {
                            Console.Write("| {0,5} |", " ");
                            continue;
                        }
                    }
                    Console.Write("| {0,5:00.00} |", matrix[i, k]);


                }
                Console.WriteLine();
            }
        }
    }
}
