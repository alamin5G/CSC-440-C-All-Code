using System.Runtime.CompilerServices;
using MyLib;
namespace MyApp{
    class MyClass{
        class Class2{
            
            public void print(){
                Console.WriteLine("Class 2 From MyApp Program.cs");
            }
        }
        class Class3{
            protected int x=10;
            public void print(){
                Console.WriteLine("Class 3 From MyApp with the value of X = "+x);
            }
        }
        class Class5:Class3{
            
            public void print(){
                Console.WriteLine("Class 5 extends Class 3 From MyApp with the inherited value of X = "+x);
            }
        }
        public static void Main(){
           Class1 c=new Class1();
           c.print();
           Class2 c2=new Class2();
           c2.print();
            Class3 c3=new Class3();
            c3.print();
            Class4 c4=new Class4();
            c4.print();
            Class5 c5=new Class5();
            c5.print();
        }
    }
}