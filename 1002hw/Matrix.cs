using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002hw
{
    class Matrix
    {
        private int[,] arr;
        public int rows
        {
            get;
            private set;
        }
        public int cols
        {
            get;
            private set;
        }
        public Matrix(int _rows, int _cols)
        {
            rows = _rows;
            cols = _cols;
            arr = new int[rows, cols];
        }
        public int FindMin()
        {
            int max = arr[0,0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)

                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }

        public int FindMax()
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)

                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }

        public static Matrix operator +(Matrix arr1, Matrix arr2)
        {
            if (arr1.rows != arr2.rows && arr1.cols != arr2.cols)
            {
                throw new Exception("Invalid matrix sizes");
            }
            Matrix result = arr1;
            for (int i = 0; i < result.arr.GetLength(0); i++)
            {
                for (int j = 0; j < result.arr.GetLength(1); j++)

                {
                    result[i, j] = arr1[i,j]+arr2[i,j];
                }
            }
            return result;
        }

        public static Matrix operator -(Matrix arr1, Matrix arr2)
        {
            if (arr1.rows != arr2.rows && arr1.cols != arr2.cols)
            {
                throw new Exception("Invalid matrix sizes");
            }
            Matrix result = arr1;
            for (int i = 0; i < result.arr.GetLength(0); i++)
            {
                for (int j = 0; j < result.arr.GetLength(1); j++)

                {
                    result[i, j] = arr1[i, j] - arr2[i, j];
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix arr1,Matrix arr2)
        {
            Matrix result = arr1;
            if (arr1.arr.GetLength(2) != arr2.arr.GetLength(1))
            {
                Console.WriteLine("Error");
            }
            else
            {
                for (int i = 0; i < arr1.arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr2.arr.GetLength(1); j++)

                    {
                        for (int k = 0; k < arr1.arr.GetLength(1); k++)
                        {
                            result[i, j] = arr1[i, k] * arr2[k, j];
                        }
                    }
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix arr1, int num)
        {

            Matrix result = arr1;
            for (int i = 0; i < result.arr.GetLength(0); i++)
            {
                for (int j = 0; j < result.arr.GetLength(1); j++)

                {
                    result[i, j] = arr1[i, j] * num;
                }
            }
            return result;
        }

        public static bool operator ==(Matrix arr1, Matrix arr2)
        {
            if (arr1.rows != arr2.rows && arr1.cols != arr2.cols)
            {
                throw new Exception("Invalid matrix sizes");
            }
            for (int i = 0; i < arr1.arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.arr.GetLength(1); j++)

                {
                    if (arr1[i, j] != arr2[i, j])
                    {
                        return false;
                    }
                }
                Console.WriteLine();
            }
            return true;
        }

        public static bool operator !=(Matrix arr1, Matrix arr2)
        {
            if (arr1.rows != arr2.rows && arr1.cols != arr2.cols)
            {
                throw new Exception("Invalid matrix sizes");
            }
            for (int i = 0; i < arr1.arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.arr.GetLength(1); j++)

                {
                    if (arr1[i, j] != arr2[i, j])
                    {
                        return true;
                    }
                }
                Console.WriteLine();
            }
            return false;
        }
  
        public void Input()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Enter a number for row "+i+" col "+j+":");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        public void Print()
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public int this[int r, int c]
        {
            get
            {
                if (r < 0 || r >= arr.GetLength(0))
                {
                    throw new Exception("Некорректный индекс! " + r);
                }
                else if (c < 0 || c >= arr.GetLength(1))
                {
                    throw new Exception("Некорректный индекс! " + c);
                }
                else
                    return arr[r, c];
            }
            set
            {
                if (r < 0 || r >= arr.GetLength(0))
                {
                    throw new Exception("Некорректный индекс! " + r);
                }
                else if (c < 0 || c >= arr.GetLength(1))
                {
                    throw new Exception("Некорректный индекс! " + c);
                }
                else
                    arr[r, c] = value;
            }
        }
    }
}
