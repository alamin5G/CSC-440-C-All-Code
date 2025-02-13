using MyProject;

namespace MyPackage { 
    public class myClass
{
        static void Main(String[] args)
        {
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
            Console.WriteLine("Length of the jagged array at 1 is: " + jaggedArray[1].Length);
            Console.WriteLine("Sum of the jagged array is: " + jaggedArray1.sumOfJaggedArray());

        }
    }
}

