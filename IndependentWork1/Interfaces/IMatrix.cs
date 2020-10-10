﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IndependentWork1.Interfaces
{
    interface IMatrix : IEnumerable
    {
        int RowNumber { get; }
        int ColumnNumber { get; }

        double this[int rowIndex, int columnIndex] { get; set; }

        double getValue(int rowIndex, int columnIndex);

        int setValue(double value, int rowIndex, int columnIndex);
    }
}