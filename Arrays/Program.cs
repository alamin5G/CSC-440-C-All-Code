class Program{
    static void Main(string[] args)
    {
        // Declare and initialize an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Print the elements of the array
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        // Modify an element in the array
        numbers[0] = 10;

        // Print the modified array
        Console.WriteLine("Modified array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        // array sort
        Array.Sort(numbers);
        Console.WriteLine("Sorted array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}