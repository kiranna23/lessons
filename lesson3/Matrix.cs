using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Matrix
    {
        int[,] MyMatrix;
        int rows;
        int columns;

        public Matrix(int rows, int columns)
        {
            this.rows = rows;   
            this.columns = columns;
            MyMatrix = new int[rows, columns];       
        }

        public Matrix(int[,] matrix)
        {
            rows = matrix.GetLength(0);
            columns = matrix.GetLength(1);  
            MyMatrix = new int[rows, columns];  
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    MyMatrix[i, j] = matrix[i, j];
                }
            }
        }

        public void InputRandom()
        {
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    MyMatrix[i, j] = rnd.Next(10);
                }
            }
        }

        public void InputByHands()
        {
            Console.Write("Enter the matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    MyMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        public void OutputMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for(int j=0;  j < columns; j++)
                {
                    Console.Write(MyMatrix[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sum += MyMatrix[i, j];
                }
            }
            return sum;
        }

        public void Diagonal()
        {
            if (columns == rows)
            {
                Console.Write("The main diagonal: ");
                for (int i = 0; i < rows; i++)
                {
                    Console.Write(MyMatrix[i, i] + " ");
                }
                Console.Write("\nThe side diagonal: ");
                for (int i = 0; i < rows; i++)
                {
                    Console.Write(MyMatrix[i, rows - 1 - i] + " ");
                }
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("Fatal: matriix isn't a diagonal");    
            }
        }

        public void SortMatrix()
        {
            int[] row = new int[columns];
            ArrayInt array = new ArrayInt(columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    row[j] = MyMatrix[i, j];
                }
                array.CopyArray(row);
                array.SortArray();
                row = array.ReturnArray();
                for (int j = 0; j < columns; j++)
                {
                    MyMatrix[i, j] = row[j];
                }
            }
        }

        public int[,] ReturnMatrix()
        {
            return MyMatrix;
        }

        public int ReturnRows()
        {
            return rows;    
        }

        public int ReturnColumns()
        {
            return columns;
        }

        public int[,] Multiplication(Matrix matrix)
        {
            int[,] matrixB = matrix.ReturnMatrix();
            int[,] matrixC = new int[rows, matrix.ReturnColumns()];
            if (columns == matrix.ReturnRows())
            {
                for (int i = 0; i < MyMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrixB.GetLength(0); k++)
                        {
                            matrixC[i, j] += MyMatrix[i, k] * matrixB[k, j];
                        }
                    }
                }        
                return matrixC; 
            }
            else
            {
                Console.WriteLine("Fatal: You cannot multiply matrices!");
                return null;
            }
        }
    }
}
