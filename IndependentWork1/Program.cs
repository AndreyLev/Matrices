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
            int rowCount;
            int columnCount;
            int nonValueElementsNumber;
            int matrixMaxValue;
            Console.WriteLine("----Пустые значения - нулевые значения----\n");

            Console.WriteLine("----ПЛОТНАЯ МАТРИЦА----");
            rowCount = 5;
            columnCount = 12;
            nonValueElementsNumber = 14;
            matrixMaxValue = 25;
            DenseMatrix denseMatrix = new DenseMatrix(rowCount, columnCount);
            MatrixInitiator.FillMatrix(denseMatrix, nonValueElementsNumber, matrixMaxValue);
            MatrixStatistics denseMatrixStatistics = new MatrixStatistics(denseMatrix);
            Console.WriteLine("Размер матрицы: {0} x {1}", denseMatrix.RowNumber, denseMatrix.ColumnNumber);
            denseMatrix.printMatrix();
            Console.WriteLine("Сумма элементов матрицы: " + denseMatrixStatistics.ValuesSum);
            Console.WriteLine("Среднее значение матрицы: " + denseMatrixStatistics.Mean);
            Console.WriteLine("Максимальное значение матрицы: " + denseMatrixStatistics.MaxValue);
            Console.WriteLine("Количество ненулевых элементов: " + denseMatrixStatistics.nonValuesElementsCount);

            Console.WriteLine();

            Console.WriteLine("----РАЗРЕЖЕННАЯ МАТРИЦА----");
            rowCount = 7;
            columnCount = 5;
            nonValueElementsNumber = 12;
            matrixMaxValue = 15;
            SparseMatrix sparseMatrix = new SparseMatrix(rowCount, columnCount);
            MatrixInitiator.FillMatrix(sparseMatrix, nonValueElementsNumber, matrixMaxValue);
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
