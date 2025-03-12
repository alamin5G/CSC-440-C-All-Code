using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstLab
{
    public class MyClass

    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of input you want to provide: ");
            Console.WriteLine("1. Integer type input");
            Console.WriteLine("2. String type input");
            Console.WriteLine("3. Double type input");
            Console.WriteLine("4. Boolean type input");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice){
                case 1:
                    Console.Write("Enter the integer value: ");
                    int intVal = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The integer value is: " + intVal);
                    break;
                case 2:
                    Console.Write("Enter the string value: ");
                    string strVal = Console.ReadLine();
                    Console.WriteLine("The string value is: " + strVal);
                    break;
                case 3:
                    Console.Write("Enter the double value: ");
                    double doubleVal = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("The double value is: " + doubleVal);
                    break;
                case 4:
                    Console.Write("Enter the boolean value: ");
                    bool boolVal = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("The boolean value is: " + boolVal);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            //singleArray();
            InventorySystem inventorySystem = new InventorySystem();
            inventorySystem.addInventory(1, 10);
            inventorySystem.addInventory(2, 20);
            inventorySystem.removeInventory(2, 11);
            inventorySystem.findLowInventory();
        }

        private static void singleArray(){
             Console.Write("Enter the array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the array elements: ");
            for(int i=0; i<size; i++){

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The array elements are: ");
            foreach(int i in arr){
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        private static void doubleArray(){
            Console.Write("Enter the row size: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[row, row];
            Console.WriteLine("Enter the array elements: ");
            for(int i= 0; i< arr.GetLength(0); i++){
                for(int j = 0; j< arr.GetLength(1); j++){
                    Console.Write("Enter the element at position [" + i + ", " + j + "]: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The array elements are: ");
            for(int i = 0; i< arr.GetLength(0); i++){
                for(int j = 0; j < arr.GetLength(1); j++){
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void jaggedArray(){
            Console.Write("Enter the row size: ");
            int row = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[row][];
            Console.WriteLine("Now set the colum size for each row: ");
           
            for(int i = 0; i<arr.Length; i++){  
            Console.Write("Enter the column size arr[" + i + "]: ");
            int col = Convert.ToInt32(Console.ReadLine());
            arr[i] = new int[col];	
            }

            Console.WriteLine("Enter the array elements: ");
            for(int i = 0; i < arr.Length; i++){
                for(int j = 0; j < arr[i].Length; j++){
                    Console.Write("Enter the element at [" + i + ", " + j + "]: ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The array elements are: ");
            for(int i = 0; i < arr.Length; i++){
                for(int j = 0; j < arr[i].Length; j++){
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}