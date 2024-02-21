using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayInt array = new ArrayInt(10); //exercise 0
            array.InputRandom();
            array.Output();
            Console.Write("Enter a number to search in the array: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (array.NumberInArray(number) > 0)
            {
                Console.WriteLine("The number is included in the array");
            }
            else
            {
                Console.WriteLine("The number isn't included in the array");
            }

            array.InputRandom(); //exercise 1
            array.Output();
            Console.Write("Enter a number to delete in the array: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (array.DeleteNumber(number))
            {
                array.Output();
            }
            else
            {
                Console.WriteLine("The number isn't included in the array");
            }

            int size = 0; //exercise 2
            Console.Write("Enter a size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            ArrayInt array1 = new ArrayInt(size);
            array1.InputRandom();
            array1.Output();
            Console.WriteLine("Minimum: " + array1.min() + ", maximum: " + array1.max() + ", average: " + array1.average() + "\n");

            ArrayInt FirstArray = new ArrayInt(5);  //exercise 3
            ArrayInt SecondArray = new ArrayInt(5);
            FirstArray.InputRandom();
            SecondArray.InputRandom();
            FirstArray.Output();
            SecondArray.Output();
            double average1 = FirstArray.average();
            double average2 = SecondArray.average();
            Console.WriteLine("The first average: " + average1 + ", the second average: " + average2);
            if (average1 > average2)
            {
                Console.WriteLine("The average of the first array is more than the second.");
            }
            else if (average1 < average2)
            {
                Console.WriteLine("The average of the second array is more than the first.");
            }
            else
            {
                Console.WriteLine("The averages is equal.");
            }

            bool check = false;  //exercise 4
            int n = 0;
            Console.Write("Enter size (5, 10]: ");
            n = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (n > 5 && n <= 10)
                {
                    check = true;
                }
                else
                {
                    Console.Write("Enter the size again: ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
            } while (!check);
            array = new ArrayInt(n);
            array.InputRandom();
            array.Output();
            int[] NewArray = array.EvenNumber();
            if (NewArray.Length > 0)
            {
                ArrayInt array2 = new ArrayInt(NewArray);
                Console.Write("An array of even elements of the first array - ");
                array2.Output();
            }
            else
            {
                Console.WriteLine("Array hasn't even numbers");
            }

            array = new ArrayInt(10); //exercise 5
            array.InputRandom();
            array.Output();
            array.ChangeOnZero();
            Console.Write("An array with zeros under no even indexes - ");
            array.Output();

            ArrayStr names = new ArrayStr(); //exercise 6
            names.Output();
            names.SortArray();
            Console.Write("Sorted names: ");
            names.Output();

            array = new ArrayInt(10);  //exercise 7
            array.InputRandom();
            array.Output();
            array.SortArray();
            Console.Write("Sorted ");
            array.Output();

            Matrix matrix = new Matrix(3, 4); //exercise 8
            matrix.InputByHands();
            matrix.OutputMatrix();
            Matrix matrix1 = new Matrix(4, 3);
            matrix1.InputByHands();
            matrix1.OutputMatrix();
            int[,] MyMatrix = matrix.Multiplication(matrix1);
            Matrix matrix2 = new Matrix(MyMatrix);
            Console.WriteLine("The matrix after multiplication\n");
            matrix2.OutputMatrix();

            matrix = new Matrix(3, 3); //exercise 9
            matrix.InputRandom();
            matrix.OutputMatrix();
            Console.WriteLine("Sum of matrix is " + matrix.Sum() + "\n\n");

            matrix = new Matrix(4, 4); //exercise 10
            matrix.InputRandom();
            matrix.OutputMatrix();
            matrix.Diagonal();

            matrix.OutputMatrix();  //exercise 11
            matrix.SortMatrix();
            Console.WriteLine("Sorted matrix");
            matrix.OutputMatrix();
        }
    }
}
