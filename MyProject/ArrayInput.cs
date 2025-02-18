using System;
using System.Linq;

class ArrayInput {
    

    public void reverseArray(int[] arr){
       Array.Reverse(arr);
    }
    
    public void printArray(int[] arr){
        foreach(int i in arr){
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public int[] removeDuplicateElement(int[] arr){
        return arr.Distinct().ToArray();
    }

    public int findMaxElement(int[] arr){

        return arr.Max();
    }

    public int findMinElement(int[] arr){
        return arr.Min();
    }

    public void frequencyCount(int[] arr){
        Dictionary<int, int> map = new Dictionary<int, int>();
        foreach(int i in arr){
            if(map.ContainsKey(i)){
                map[i]++;
            }else{
                map[i] = 1;
            }
        }
        foreach(KeyValuePair<int, int> entry in map){
            Console.WriteLine(entry.Key + " : " + entry.Value);
        }
    }

}