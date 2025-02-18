using MyProject;

namespace MyPackage { 
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
        }
    }
}

