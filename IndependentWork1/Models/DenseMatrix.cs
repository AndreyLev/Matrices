using IndependentWork1.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
                    if (matrix[i][j] == 0) Console.Write("{0,5}\t", 0);
                    else Console.Write("{0,5:##.##}\t ", matrix[i][j]);
                }
                Console.WriteLine();
            }
        }

    }
}
