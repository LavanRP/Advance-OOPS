using System;
using System.Collections.Generic;
namespace InsertionSort;
public class Program
{
    public static void Main(string[] args)
    {
        int[] intArr = {45,33,12,55,77,22,33,14,67,12,35};
        Console.WriteLine("Ascending order Insertion Sort");
        AscendingInsertion<int>(intArr);
        Console.WriteLine("Descending order Insertion Sort");
        DescendingInsertion<int>(intArr);
        Console.WriteLine();

        double[] doubleArr = {1.1,65.3,93.9,55.5,3.5,6.9};
        Console.WriteLine("Ascending order Insertion Sort");
        AscendingInsertion<double>(doubleArr);
        Console.WriteLine("Descending order Insertion Sort");
        DescendingInsertion<double>(doubleArr);
        Console.WriteLine();

        string[] stringArr = {"SF3023","SF3021","SF3067","SF3043","SF3053","SF3032","SF3063","SF3089","SF3062","SF3092"};
        Console.WriteLine("Ascending order Insertion Sort");
        AscendingInsertion<string>(stringArr);
        Console.WriteLine("Descending order Insertion Sort");
        DescendingInsertion<string>(stringArr);
        Console.WriteLine();

        char[] charArr = {'c','a','f','b','k','h','z','t','m','p','l','d'};
        Console.WriteLine("Ascending order Insertion Sort");
        AscendingInsertion<char>(charArr);
        Console.WriteLine("Descending order Insertion Sort");
        DescendingInsertion<char>(charArr);
    }
    public static void AscendingInsertion<Type>(Type[] arr)
    {
        for(int i = 1;i<arr.Length;i++)
        {
            Type key = arr[i];
            int j = i - 1;
            while(j>=0 && Comparer<Type>.Default.Compare(arr[j],key) > 0)
            {
                arr[j+1]=arr[j];
                j--;
            }
            arr[j+1] = key;
        }
        foreach(Type a in arr)
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine();
    }
    public static void DescendingInsertion<Type>(Type[] arr)
    {
        for(int i = 1;i<arr.Length;i++)
        {
            Type key = arr[i];
            int j = i - 1;
            while(j>=0 && Comparer<Type>.Default.Compare(arr[j],key) < 0)
            {
                arr[j+1]=arr[j];
                j--;
            }
            arr[j+1] = key;
        }
        foreach(Type a in arr)
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine();
    }
}