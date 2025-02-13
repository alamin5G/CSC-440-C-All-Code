using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstLab
{
    public class MyClass

    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Toyota" };
        int[] myNum = { 10, 20, 30, 40, 50 };
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 }, {9, 0, 2} };

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Rank);
            Console.WriteLine(numbers.GetLength(0));
            Console.WriteLine(numbers.GetLength(1));


        


           for(int i = 0; i< numbers.GetLength(0); i++)
            {
                for(int j = 0; j< numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}