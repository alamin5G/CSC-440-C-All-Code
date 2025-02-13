using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject
{
    public class JaggedArray
    {
        int[][] jaggedArray;
        public JaggedArray(int[][] jaggedArray)
        {
            this.jaggedArray = jaggedArray;
        }

        public int sumOfJaggedArray()
        {
            int sum = 0;
            int finalSum = 0;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    sum += jaggedArray[i][j];
                    Console.Write(jaggedArray[i][j] + " + ");
                }
                Console.WriteLine(" = " + sum);
             
                finalSum+= sum;
                sum = 0;
            }
            return finalSum;
        }
    }
}