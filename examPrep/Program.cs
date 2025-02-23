class Program{
    static void Main(string[] args){
        Console.Write("Enter class no: ");
        int classNo = Convert.ToInt32(Console.ReadLine());
        int[][] calsses = new int[classNo][];
        for(int i = 0; i < classNo; i++){
            Console.Write("Enter student no for class " + (i + 1) + ": ");
            int studentNo = Convert.ToInt32(Console.ReadLine());
            calsses[i] = new int[studentNo];
        }

        for(int i = 0; i < calsses.Length; i++){
            for(int j = 0; j < calsses[i].Length; j++){
                Console.Write("Enter marks for student " + (j + 1) + " in class " + (i + 1) + ": ");
                calsses[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Topper in each class");
        int[] topper = getTooer(calsses);
        for(int i = 0; i < topper.Length; i++){
            Console.WriteLine("Class " + (i + 1) + ": " + topper[i]);
        }

        Console.WriteLine("Topper in all classes: " + getTop(topper));
    
    }

    public static int[] getTooer(int[][] calsses){
        int[] topper = new int[calsses.Length];
        for(int i = 0; i < calsses.Length; i++){
            topper[i] = calsses[i][0];
            for(int j = 1; j < calsses[i].Length; j++)
            {
               if(calsses[i][j] > topper[i]){
                     topper[i] = calsses[i][j];
               } 
            }
        }

        return topper;
    }

    public static int getTop(int[] topper){
        int t = topper[0];
        for(int i = 1; i < topper.Length; i++){
            if(topper[i] > t){
                t = topper[i];
            }
        }
    }


    public static int[] getTopperUsingMax(int[][] calsses){
        int[] topper = new int[calsses.Length];
        for(int i = 0; i < calsses.Length; i++){
            topper[i] = calsses[i].Max();
        }

        return topper;
    }

    public static int getTopUsingMax(int[] topper){
        return topper.Max();
    }
}