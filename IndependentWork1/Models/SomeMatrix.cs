using IndependentWork1.Interfaces;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace IndependentWork1.Models
{
    abstract class SomeMatrix : IMatrix
    {
        private IVector[] matrix;

        public int RowNumber { get; }

        public int ColumnNumber { get; }

        public SomeMatrix(int rowCount, int columnNumber)
        {
                matrix = new IVector[rowCount];
                for (int i = 0; i < rowCount; i++)
                {
                    matrix[i] = create(columnNumber);
                }
            RowNumber = rowCount;
            ColumnNumber = columnNumber;
        }

        protected abstract IVector create(int size);

        public virtual double this[int rowIndex, int columnIndex]
        { 
            get {
                if (rowIndex >= RowNumber || columnIndex >= ColumnNumber) return 0;
                return matrix[rowIndex][columnIndex];  
            }
            set {
                if (rowIndex < RowNumber && columnIndex < ColumnNumber) 
                    matrix[rowIndex][columnIndex] = value; 
            }
        }


    }
}
