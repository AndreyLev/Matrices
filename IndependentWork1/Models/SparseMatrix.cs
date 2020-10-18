using System;
using System.Collections;

namespace IndependentWork1.Models
{
    class SparseMatrix : SomeMatrix
    {

       
        public override double this[int rowIndex, int columnIndex]
        {
            get
            {
                if (rowIndex >= RowNumber) return 0;
                if (columnIndex >= ColumnNumber) return 0;
                SparseVector temp = (SparseVector)matrix[rowIndex];
                if (temp.Vector.ContainsKey(columnIndex))
                {
                    return matrix[rowIndex][columnIndex];
                }
                 
                return 0;
            }
            set
            {
                    if (rowIndex < RowNumber && columnIndex < ColumnNumber)
                          matrix[rowIndex][columnIndex] = value;
            }
        }
        public SparseMatrix(int rowCount, int columnCount)
        {
            matrix = new SparseVector[rowCount];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new SparseVector(columnCount);
            }
            RowNumber = rowCount;
            ColumnNumber = columnCount;
        }
        public override IEnumerator GetEnumerator()
        {
            return new SparceMatrixEnumerator((SparseVector[]) matrix);
        }

        public void printMatrix()
        {

            for (int i = 0; i < RowNumber; i++)
            {

                for (int k = 0; k < ColumnNumber; k++)
                {
                    
                    if (this[i, k] == 0)
                    {
                        Console.Write("| {0,5} |", " ");
                        continue;
                    }
                    Console.Write("| {0,5:00.00} |", this[i, k]);
                    

                }
                Console.WriteLine();
            }

        }

        public void collapse()
        {
            SparseVector[] c_matrix = (SparseVector[]) matrix;
            for (int i = 0; i < RowNumber; i++)
            {
                for (int j = 0; j < ColumnNumber; j++)
                {
                    if (this[i,j] == 0)
                    {
                       c_matrix[i].removeElement(j);
                     
                    }
                }
            }
        }
    }
}
