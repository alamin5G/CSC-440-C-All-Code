using MyProject;

namespace MyPackage
{
    public class myClass
    {
        static void Main(String[] args)
        {
            /*
            int[] arr = { 1, 2, 3, 4, 5 };
            ArrayPractice arrayPractice = new ArrayPractice(arr);
            Console.WriteLine("Sum of the array is: " + arrayPractice.sumOfArray());

            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 6, 7, 8, 9 };
            jaggedArray[2] = new int[] { 10, 11, 12 };
            JaggedArray jaggedArray1 = new JaggedArray(jaggedArray);
            Console.WriteLine("Length of the jagged array is: " + jaggedArray.Length);
            Console.WriteLine("Rank of the jagged array is: " + jaggedArray.Rank);
            Console.WriteLine("Length of the jagged array is: " + jaggedArray.Length);
            Console.WriteLine("Sum of the jagged array is: " + jaggedArray1.sumOfJaggedArray());

            */
            /*
             Console.WriteLine("Enter the size of the array: ");
             int size = Convert.ToInt32(Console.ReadLine());
             int[] arr = new int[size];
             Console.WriteLine("Enter the elements of the array: ");
             for (int i = 0; i < size; i++){
                 arr[i] = Convert.ToInt32(Console.ReadLine());
             }
             ArrayInput arrayInput = new ArrayInput();
             arrayInput.printArray(arr);
             arrayInput.reverseArray(arr);
             arrayInput.printArray(arr);
             int[] uniqArray = arrayInput.removeDuplicateElement(arr);
             arrayInput.printArray(uniqArray);
             Console.WriteLine("Max element of the array is: " + arrayInput.findMaxElement(arr));
             Console.WriteLine("Min element of the array is: " + arrayInput.findMinElement(arr));
             arrayInput.frequencyCount(arr);
             */

            Console.Write("Set Jagged Array size: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[][] jA = new int[size][];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Initialize the size of the jA[" + i + "]:");
                int a = Convert.ToInt32(Console.ReadLine());
                jA[i] = new int[a];
            }


            Console.WriteLine("Now we are going to pass the jagged array to the function");
            inputAndPrintJaggedArray(jA);

        }



        public static void inputAndPrintJaggedArray(int[][] jaggedArray)
        {
            Console.WriteLine("Enter the elements of the jagged array: ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write("Enter the element of the jaggedArray[" + i + "][" + j + "]: ");
                    jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Printing the jagged array: ");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();


            }

        }
    }

}

