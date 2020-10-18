using IndependentWork1.Interfaces;
using System.Collections;

namespace IndependentWork1.Models
{
    abstract class SomeMatrix : IMatrix
    {
        public IVector[] matrix;
        
        public virtual double this[int rowIndex, int columnIndex]
        { 
            get { return matrix[rowIndex][columnIndex];  }
            set { matrix[rowIndex][columnIndex] = value; }
        }


        public IVector[] MATRIX { get { return matrix; } }

        public int RowNumber { get; protected set;  }

        public int ColumnNumber { get; protected set;  }

        public abstract IEnumerator GetEnumerator();
        

        public double getValue(int rowIndex, int columnIndex)
        {
            return matrix[rowIndex][columnIndex];
        }

        public int setValue(double value, int rowIndex, int columnIndex)
        {
            matrix[rowIndex][columnIndex] = value;
            return 1;
        }
    }
}
