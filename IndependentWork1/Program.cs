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

            //    DenseMatrix dm = new DenseMatrix(5, 4);
            //    dm.printMatrix();
            //    MatrixInitiator.FillMatrix(dm, 14, 15);
            //    Console.WriteLine();
            //    dm.printMatrix();
            //    MatrixStatistics matrixStatistics = new MatrixStatistics(dm);
            //    Console.WriteLine("Сумма элементов матрицы: " + matrixStatistics.ValuesSum);
            //    Console.WriteLine("Среднее значение матрицы: " + matrixStatistics.Mean);
            //    Console.WriteLine("Максимальное значение матрицы: " + matrixStatistics.MaxValue);
            //    Console.WriteLine("Количество ненулевых элементов: " + matrixStatistics.nonValuesElementsCount);
            //    SomeMatrix sm = new DenseMatrix(5, 4);


            //Console.WriteLine(dm.getValue(1, 1));
            //SparseMatrix sparceMatrix = new SparseMatrix(4, 5);
            //Console.WriteLine(sparceMatrix[1,2]);
            //Console.WriteLine("Рядов в sparceMatrix: " + sparceMatrix.RowNumber);
            //Console.WriteLine("Столбцов в sparceMatrix: " + sparceMatrix.ColumnNumber);



            //SparseMatrix sm1 = new SparseMatrix(5, 4);

            //sm1.printMatrix();

            //MatrixInitiator.FillMatrix(sm1, 14, 15);

            //Console.WriteLine();

            //sm1.printMatrix();
            //MatrixStatistics matrixStatistics1 = new MatrixStatistics(sm1);
            int matricesCount = 5000;
            List<SparseMatrix> smList = new List<SparseMatrix>();
            List<MatrixStatistics> msList = new List<MatrixStatistics>();
            while (smList.Count != matricesCount) smList.Add(new SparseMatrix(4, 5));
            

            
            for (int i = 0; i < smList.Count; i++)
            {
                msList.Add(new MatrixStatistics(smList[i]));
                MatrixInitiator.FillMatrix(smList[i], 14, 15);
                Console.WriteLine("-----------------------------");
                smList[i].printMatrix();
                
       
                Console.WriteLine("Сумма элементов матрицы: " + msList[i].ValuesSum);
                Console.WriteLine("Среднее значение матрицы: " + msList[i].Mean);
                Console.WriteLine("Максимальное значение матрицы: " + msList[i].MaxValue);
                Console.WriteLine("Количество ненулевых элементов: " + msList[i].nonValuesElementsCount);
            }
            //Console.WriteLine("Сумма элементов матрицы: " + matrixStatistics1.ValuesSum);
            //Console.WriteLine("Среднее значение матрицы: " + matrixStatistics1.Mean);
            //Console.WriteLine("Максимальное значение матрицы: " + matrixStatistics1.MaxValue);
            //Console.WriteLine("Количество ненулевых элементов: " + matrixStatistics1.nonValuesElementsCount);
            Console.WriteLine("Конец тестирования");
        }
    }
}
