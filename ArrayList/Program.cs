using System;

class MyClass{
    static void Main(string[] args){
        int[,] arr = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        //print the 2d array size
        Console.WriteLine("The 2d array size is: " + arr.Length);
        // Display the 2d array elements
        for(int i = 0; i < arr.Length; i++){
        
            for(int j = 0; j < arr.GetLength(1); j++){
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("======================");

        // Display the 2d array elements
       for(int i = 0; i < arr.GetLength(0); i++){
            for(int j = 0; j < arr.GetLength(1); j++){
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
       }
    }
}