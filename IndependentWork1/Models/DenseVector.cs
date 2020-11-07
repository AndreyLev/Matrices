using IndependentWork1.Interfaces;
using System;

namespace IndependentWork1.Models
{
    class DenseVector : IVector
    {
        double[] coords;

        public int DIM { get; }

        public double this[int index]
        {
            get { 
                if (index <  DIM)
                    return coords[index];

                return 0;
            }
            set { 
                if (index < DIM)
                   coords[index] = value; 
            }
        }

        public DenseVector(int coordsCount)
        {
            coords = new double[coordsCount];
            DIM = coordsCount;
        }

        public void printValue()
        {
            for (int i = 0; i < coords.Length; i++)
            {
                Console.Write(coords[i] +  "\t");
            }
        }
    }
}
