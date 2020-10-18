using System;
using System.Collections;


namespace IndependentWork1.Models
{
    class DenseMatrix : SomeMatrix
    {


        public DenseMatrix(int rowCount, int columnCount)
        {
            matrix = new DenseVector[rowCount];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new DenseVector(columnCount);
            }
            RowNumber = rowCount;
            ColumnNumber = columnCount;
        }

        public override IEnumerator GetEnumerator()
        {
            return new DenseMatrixEnumerator((DenseVector[]) matrix);
        }

        public void printMatrix()
        {
            
            for (int i = 0; i < RowNumber; i++)
            {
                for (int j = 0; j < ColumnNumber; j++)
                {
                    Console.Write("| {0,-5:00.00} |", matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

    }
}
