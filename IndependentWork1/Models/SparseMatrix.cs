﻿using IndependentWork1.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IndependentWork1.Models
{
    class SparseMatrix : SomeMatrix
    {
        new SparseVector[] matrix;

        public SparseVector[] Matrix { 
            
            get
            {
                return matrix;
            } 
        }

        public override double this[int rowIndex, int columnIndex]
        {
            get
            {
                if (rowIndex >= RowNumber) return 0;
                if (columnIndex >= ColumnNumber) return 0;

                if (matrix[rowIndex].Vector.Keys.Contains(columnIndex))
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
            return new SparceMatrixEnumerator(matrix);
        }

        public void printMatrix()
        {
           
            for (int i = 0; i < matrix.Length; i++)
            {
                
                for (int k = 0; k < ColumnNumber; k++)
                {
                    if (matrix[i].Vector.ContainsKey(k))
                    {
                        if (matrix[i][k] == 0) Console.Write("0\t");
                        else Console.Write("{0,5:##.##}\t ", matrix[i][k]);
                    }
                    else Console.Write("{0,5}\t", 0);
                    
                    
                    
                }
                

                Console.WriteLine();
            }
        }

        public void collapse()
        {
            for (int i = 0; i < RowNumber; i++)
            {
                for (int j = 0; j < ColumnNumber; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                       matrix[i].removeElement(j);
                     
                    }
                }
            }
        }
    }
}