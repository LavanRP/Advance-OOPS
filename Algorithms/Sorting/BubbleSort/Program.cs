using System;
using System.Collections.Generic;
namespace BubbleSort;
public class Program
{
    public static void Main(string[] args)
    {
        int[] intArr = {45,33,12,55,77,22,33,14,67,12,35};
        Console.WriteLine("Ascending orded Bubble Sorting");
        AscendingBubble<int>(intArr);
        Console.WriteLine();
        Console.WriteLine("Descending orded Bubble Sorting");
        DescendingBubble<int>(intArr);
        Console.WriteLine();

        double[] doubleArr = {1.1,65.3,93.9,55.5,3.5,6.9};
        Console.WriteLine("Ascending orded Bubble Sorting");
        AscendingBubble<double>(doubleArr);
        Console.WriteLine();
        Console.WriteLine("Descending orded Bubble Sorting");
        DescendingBubble<double>(doubleArr);
        Console.WriteLine();

        string[] stringArr = {"SF3023","SF3021","SF3067","SF3043","SF3053","SF3032","SF3063","SF3089","SF3062","SF3092"};
        Console.WriteLine("Ascending orded Bubble Sorting");
        AscendingBubble<string>(stringArr);
        Console.WriteLine();
        Console.WriteLine("Descending orded Bubble Sorting");
        DescendingBubble<string>(stringArr);
        Console.WriteLine();

        char[] charArr = {'c','a','f','b','k','h','z','t','m','p','l','d'};
        Console.WriteLine("Ascending orded Bubble Sorting");
        AscendingBubble<char>(charArr);
        Console.WriteLine();
        Console.WriteLine("Descending orded Bubble Sorting");
        DescendingBubble<char>(charArr);
    }
    public static void  AscendingBubble<Type>(Type[] arr)
    {
        for(int i = 0;i<arr.Length-1;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(Comparer<Type>.Default.Compare(arr[j],arr[j+1])>0)
                {
                    Type temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        foreach(Type a in arr)
        {
            Console.Write($"{a} ");
        }
    }
    public static void  DescendingBubble<Type>(Type[] arr)
    {
        for(int i = 0;i<arr.Length;i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(Comparer<Type>.Default.Compare(arr[j],arr[j+1])<0)
                {
                    Type temp = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = temp;
                }
            }
        }
        foreach(Type a in arr)
        {
            Console.Write($"{a} ");
        }
        Console.WriteLine();
    } 
}