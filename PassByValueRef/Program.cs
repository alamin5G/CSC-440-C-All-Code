
public partial class Program
{

    static void Main()
    {
        Console.WriteLine("Enter days no: 1 to 7");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine((days)day);

        Console.WriteLine("Enter a number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before pass by value: " + a);
        passByValue(a);
        Console.WriteLine("After pass by value: " + a);
        Console.WriteLine();
        Console.WriteLine("Before pass by ref: " + a);
        passByRef(ref a);  
        Console.WriteLine("After pass by ref: " + a);
        Console.WriteLine();
        int b; 
       // Console.WriteLine("Before pass by out: " + b); 
        passByOut(out b);
        Console.WriteLine("After pass by out: " + b);
    }

    private static void passByValue(int a)
    {
        a++;
    }

    private static void passByRef(ref int a)
    {
        a++;
    }

    private static void passByOut(out int c)
    {
        c = 10;
    }
}
   enum days { Saturday = 1,  sunday, monday, tuesday, wednesday, thursday, friday };