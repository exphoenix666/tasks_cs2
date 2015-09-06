using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Konstantin
{
    class Matrix <T> where T: Number<T>
    {
        public Matrix(int height, int width)
        {
            
        }
        public T this[int row, int col]
        {
            get { return internalData[row][col]; }
            set { }
        }
        private T[][] internalData;
        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            Matrix<T> resultMatrix = new Matrix<T>(m1.internalData.Length, m1.internalData[0].Length);
            for (int i = 0; i < m1.internalData.Length; i++)
            {
                for (int j = 0; j < m1.internalData[0].Length; j++)
                {
                    resultMatrix.[i][j] = m1.[i][j]+ m2.[i][j];
                }
            }
        }
    }
}
