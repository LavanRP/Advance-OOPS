using System;
using System.Collections.Generic;
namespace BinarySearch;
public class Program
{
    public static void Main(string[] args)
    {
        int[] intArr = {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        Array.Sort(intArr);
        int intPosition=Binary<int>(intArr,66);
        Console.WriteLine($"the element {66} present in {intPosition} position after Shorting the array");

        string[] stringArr = {"SF3023","SF3021","SF3067","SF3043","SF3053","SF3032","SF3063","SF3089","SF3062","SF3092"};
        Array.Sort(stringArr);
        int stringPosition = Binary<string>(stringArr,"SF3067");
        Console.WriteLine($"the element {"SF3067"} present in {stringPosition} position after Shorting the array");

        char[] charArr = {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        Array.Sort(charArr);
        int charPosition = Binary<char>(charArr,'m');
        Console.WriteLine($"the element {"m"} present in {charPosition} position after Shorting the array");

        double[] doubleArr = {1.1,65.3,93.9,55.5,3.5,6.9};
        Array.Sort(doubleArr);
        int doublePosition = Binary<double>(doubleArr,3.5);
        Console.WriteLine($"the element {3.5} present in {doublePosition} position after Shorting the array");
    }
    public static int Binary<Type>(Type[] arr,Type find)
    {
        int left = 0;
        int right = arr.Length-1;
        
        while(left<=right)
        {
            int middle = left+((right-left)/2);
            if(arr[middle].Equals(find))
            {
                return middle;
            }
            else if(Comparer<Type>.Default.Compare(arr[middle],find)>0)//compares 
            {
                right = middle - 1;
            }
            else
            {
                left = middle + 1;
            }
        }
        return -1;
    }
}