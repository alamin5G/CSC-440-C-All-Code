class Program{
    static void Main(string[] args){

        

        int[] arr = {1,2,3,4,5};
        Console.WriteLine("Enter the index of the array");
        try{
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( $"The array element in the index {index} is : " + arr[index]);
           

        }catch(IndexOutOfRangeException e){
            Console.WriteLine("You cannot access because: " + e.Message);
        }finally{
            Console.WriteLine("This is the finally block 1 for array access");
        }

        try{
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            division(a, b);
        }catch(DivideByZeroException e){
            Console.WriteLine("You cannot divide because: " + e.Message);
        }finally{
            Console.WriteLine("This is the finally block 2 for division");
        }
        Console.WriteLine("End of program");
    }



    static void division(int a, int b) {
        if(b == 0){
            throw new DivideByZeroException("Cannot divide by zero");
        }else
        {
            Console.WriteLine(a/b);
        }
    }

}