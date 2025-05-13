using System;

class MyClass{
    static void Main(string[] args){
        Console.WriteLine("Enter the row size of array: ");
        int row = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the column size of array: ");
        int col = Convert.ToInt32(Console.ReadLine());
        //int[,] arr = new int[row, col];
        // Create a jagged array
        int[][] jaggedArray = new int[row][];
        // Fill the jagged array with random numbers
        Random rand = new Random();
        // Fill the jagged array with random numbers
        for (int i = 0; i< jaggedArray.Length; i++){
            Console.WriteLine("Enter the size of row " + i + ": ");
            int size = Convert.ToInt32(Console.ReadLine());
            jaggedArray[i] = new int[size];
            for (int j = 0; j < size; j++){
                jaggedArray[i][j] = rand.Next(1, 100);
            }
        }

        // Display the jagged array elements
        Console.WriteLine("The jagged array elements are: ");
        Console.WriteLine("======================");
        for (int i = 0; i < jaggedArray.Length; i++){
            for (int j = 0; j < jaggedArray[i].Length; j++){
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
        


        // Fill the 2d array with random numbers
       /* Random rand = new Random();
        for(int i = 0; i < arr.GetLength(0); i++){
            for(int j = 0; j < col; j++){
                arr[i, j] = rand.Next(1, 100);
            }
        }*/

        //print the 2d array size
       // Console.WriteLine("The 2d array size is: " + arr.Length);
        // Display the 2d array elements
        Console.WriteLine("The 2d array elements are: ");

        Console.WriteLine("======================");

        // Display the 2d array elements
       /*for(int i = 0; i < arr.GetLength(0); i++){
            for(int j = 0; j < arr.GetLength(1); j++){
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
       }*/
    }
}