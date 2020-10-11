using IndependentWork1.Interfaces;
using IndependentWork1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IndependentWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Пустые значения - нулевые значения----\n");

            Console.WriteLine("----ПЛОТНАЯ МАТРИЦА----");
            DenseMatrix denseMatrix = new DenseMatrix(5, 12);
            MatrixInitiator.FillMatrix(denseMatrix, 14, 25);
            MatrixStatistics denseMatrixStatistics = new MatrixStatistics(denseMatrix);
            Console.WriteLine("Размер матрицы: {0} x {1}", denseMatrix.RowNumber, denseMatrix.ColumnNumber);
            denseMatrix.printMatrix();
            Console.WriteLine("Сумма элементов матрицы: " + denseMatrixStatistics.ValuesSum);
            Console.WriteLine("Среднее значение матрицы: " + denseMatrixStatistics.Mean);
            Console.WriteLine("Максимальное значение матрицы: " + denseMatrixStatistics.MaxValue);
            Console.WriteLine("Количество ненулевых элементов: " + denseMatrixStatistics.nonValuesElementsCount);

            Console.WriteLine();

            Console.WriteLine("----РАЗРЕЖЕННАЯ МАТРИЦА----");
            SparseMatrix sparseMatrix = new SparseMatrix(7, 5);
            MatrixInitiator.FillMatrix(sparseMatrix, 12, 15);
            MatrixStatistics sparseMatrixStatistics = new MatrixStatistics(sparseMatrix);
            Console.WriteLine("Размер матрицы: {0} x {1}", sparseMatrix.RowNumber, sparseMatrix.ColumnNumber);
            sparseMatrix.printMatrix();
            Console.WriteLine("Сумма элементов матрицы: " + sparseMatrixStatistics.ValuesSum);
            Console.WriteLine("Среднее значение матрицы: " + sparseMatrixStatistics.Mean);
            Console.WriteLine("Максимальное значение матрицы: " + sparseMatrixStatistics.MaxValue);
            Console.WriteLine("Количество ненулевых элементов: " + sparseMatrixStatistics.nonValuesElementsCount);
            
        }
    }
}
