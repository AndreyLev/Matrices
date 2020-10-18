using IndependentWork1.Interfaces;
using System;
using System.Collections.Generic;

namespace IndependentWork1.Models
{
    class SparseVector : IVector
    {
        public int DIM { get; set; }

        SortedList<int, double> vector;

        public SortedList<int, double> Vector
        {
            get { return vector; }
        }
        
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
            }
        }

        public SparseVector(int dim)
        {
            vector = new SortedList<int, double>(dim);
            for (int i = 0; i <= dim; i++)
            {
                vector.Add(i, 0);
            }
            DIM = dim;
        }

        public bool removeElement(int key)
        {
            return vector.Remove(key); 
        }
        public double getValue(int index)
        {
            return this[index];
        }

        public SortedList<int, double> getVector()
        {
            return vector;
        }

        public int setValue(int index, double value)
        {
            this[index] = value;
            return 1;
        }

        public void getKeys()
        {
            Console.WriteLine("\n" + vector.Keys);
        }
    }
}
