using System;
using System.Collections.Generic;
using System.Text;

namespace IndependentWork1.Interfaces
{
    interface IVector
    {
        public int DIM { get; }

        double this[int index] { get; set; }
        double getValue(int index);

        int setValue(int index, double value);
    }
}
