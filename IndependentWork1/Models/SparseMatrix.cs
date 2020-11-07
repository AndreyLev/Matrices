using IndependentWork1.Interfaces;
using System;

namespace IndependentWork1.Models
{
    class SparseMatrix : SomeMatrix
    {

        protected override IVector create(int size)
        {
            return new SparseVector(size);
        }

        public SparseMatrix(int rowCount, int columnCount) : base(rowCount, columnCount)
        {
        }


    }
}
