using IndependentWork1.Models;
using System;

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
            Console.WriteLine("Размер матрицы: {0} x {1}", denseMatrix.RowNumber, denseMatrix.ColumnNumber);
            denseMatrix.PrintMatrix();
            denseMatrix.PrintMatrixData();

            Console.WriteLine();

            Console.WriteLine("----РАЗРЕЖЕННАЯ МАТРИЦА----");
            rowCount = 7;
            columnCount = 5;
            nonValueElementsNumber = 12;
            matrixMaxValue = 15;
            SparseMatrix sparseMatrix = new SparseMatrix(rowCount, columnCount);
            MatrixInitiator.FillMatrix(sparseMatrix, nonValueElementsNumber, matrixMaxValue);
            Console.WriteLine("Размер матрицы: {0} x {1}", sparseMatrix.RowNumber, sparseMatrix.ColumnNumber);
            sparseMatrix.PrintMatrix();
            sparseMatrix.PrintMatrixData();


        }
    }
}
