using IndependentWork1.Interfaces;
using System;
using System.Collections.Generic;

namespace IndependentWork1.Models
{
    class SparseVector : IVector
    {
        public int DIM { get; }

        SortedList<int, double> vector;
        
        public double this[int index]
        {
            get
            {
                if (vector.ContainsKey(index))
                    return vector[index];

                return 0;
            }
            set
            {
                if (vector.ContainsKey(index))
                    vector[index] = value;
                else if (index < DIM)
                {
                    vector.Add(index, value);
                }
            }
        }

        public SparseVector(int dim)
        {
            vector = new SortedList<int, double>(dim);
            DIM = dim;
        }

    }
}
