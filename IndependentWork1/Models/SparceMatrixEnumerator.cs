using System;
using System.Collections;

namespace IndependentWork1.Models
{
    /* temporarily not working */
    class SparceMatrixEnumerator : IEnumerator
    {
        SparseVector[] matrix;
        int rowPosition = -1;
        int key = -1;
        int keyCounter = 0;

        public SparceMatrixEnumerator(SparseVector[] matrix)
        {
            this.matrix = matrix;
        }

        public object Current
        {
            get
            {
                if (rowPosition == -1 || key < 0
                    || rowPosition >= matrix.Length
                    || keyCounter > matrix[rowPosition].Vector.Keys.Count)
                    throw new InvalidOperationException();
                return matrix[rowPosition][key];

            }
        }

        public bool MoveNext()
        {
            

            if (rowPosition == -1) rowPosition++;

          
            if (rowPosition < matrix.Length)
            {

               if (matrix[rowPosition].Vector.Keys.Count > 0)
                {
                    if (keyCounter < matrix[rowPosition].Vector.Keys.Count)
                    {
                        key = matrix[rowPosition].Vector.Keys[keyCounter];
                        keyCounter++;
                        
                        return true;
                    }
                    else if (keyCounter == matrix[rowPosition].Vector.Keys.Count)
                    {
                        keyCounter = 0;
                        rowPosition++;
 
                        if (rowPosition >= matrix.Length) return false;
                        
                        if (matrix[rowPosition].Vector.Keys.Count > 0)
                        {
                            key = matrix[rowPosition].Vector.Keys[keyCounter];
                            keyCounter++;
                        } else if (rowPosition < matrix.Length)
                        {
                            rowPosition++;
                            if (rowPosition == matrix.Length) return false;
                        }
                    }

                    return true;
                } else if (matrix[rowPosition].Vector.Keys.Count == 0)
                {
                    rowPosition++;
                    if (rowPosition == matrix.Length) return false;
                    keyCounter = 0;
                    key = 0;
                    return true;
                }      
                else
                {
                    return false;           
                }    

            }
            else
                return false;
        }

        public void Reset()
        {
            rowPosition = -1;
            key = -1;
            keyCounter = 0;
        }
    }
}
