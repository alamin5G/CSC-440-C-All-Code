using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject
{
    public class ArrayPractice
    {

        public int[] arr;
        public ArrayPractice(int[] arr){
            this.arr = arr;
        }

        public int sumOfArray(){
            int sum = 0;
            for(int i = 0; i < arr.Length; i++){
                sum += arr[i];
                Console.Write(arr[i] + " + ");
            }
            Console.WriteLine(" = " + sum);
            return sum;
        }
    }
}