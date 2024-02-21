using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class ArrayInt
    {
        int[] numbers;

        public ArrayInt(int size)
        {
            numbers = new int[size];    
        }

        public ArrayInt(int[] array)
        {
            numbers = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                numbers[i] = array[i];  
            }
        }
        public void CopyArray(int[] numbers)
        {
            this.numbers = numbers;
        }

        public int[] ReturnArray()
        {
            return numbers; 
        }

        public void InputRandom()
        {
            Random rnd = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(10);
            }
        }

        public void InputConsole()
        {
            Console.Write("Enter an array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.Read());
            }
        }

        public void Output()
        {
            Console.Write("array of numbers: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();    
        }

        public int NumberInArray(int number)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                {
                    count++;
                }
            }
            return count;
        }

        public bool DeleteNumber(int number)
        {
            int j = 0;
            if (NumberInArray(number)>0)
            {
                int[] NewNumbers = new int[numbers.Length - NumberInArray(number)]; 
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] != number)
                    {
                        NewNumbers[j] = numbers[i];
                        j++;
                    }
                }
                numbers = NewNumbers;   
                return true;
            }
            else
            {
                return false;
            }
        }

        public int max()
        {
            return numbers.Max();
        }
        
        public int min()
        {
            return numbers.Min();   
        }

        public double average()
        {
            return numbers.Average();   
        }

        public void ChangeOnZero()
        {
            for (int i = 1; i < numbers.Length; i=i+2)
            {
                numbers[i] = 0;
            }
        }

        public void SortArray()
        {
            int x = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        x = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = x;
                    }
                }
            }
        }

        public int[] EvenNumber()
        {
            int size = 0;
            for (int i =0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    size++; 
                }
            }
            if (size > 0)
            {
                int[] number = new int[size];
                int j = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        number[j] = numbers[i];
                        j++;
                    }
                }
                return number;  
            }
            else
            {
                return null;
            }
        }
    }
}
