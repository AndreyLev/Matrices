using IndependentWork1.Interfaces;
using System;
using System.Collections;
using System.Dynamic;

namespace IndependentWork1.Models
{
    class DenseMatrix : SomeMatrix
    {
        protected override IVector create(int size)
        {
            return new DenseVector(size);
        }
    

        public DenseMatrix(int rowCount,int columnCount) : base(rowCount, columnCount)
        { 
        }
     
    }
}
