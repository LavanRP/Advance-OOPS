using System;
using System.Collections.Generic;
namespace SelectionSort;
public class Program
{
    public static void Main(string[] args)
    {
        int[] intArr = { 45, 33, 12, 55, 77, 22, 33, 14, 67, 12, 35 };
        Console.WriteLine("Ascending Selection sort");
        AscendingSelection<int>(intArr);
        Console.WriteLine("Descending Selection sort");
        DescendingSelection<int>(intArr);
        Console.WriteLine();

        double[] doubleArr = { 1.1, 65.3, 93.9, 55.5, 3.5, 6.9 };
        Console.WriteLine("Ascending Selection sort");
        AscendingSelection<double>(doubleArr);
        Console.WriteLine("Descending Selection sort");
        DescendingSelection<double>(doubleArr);
        Console.WriteLine();

        string[] stringArr = { "SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092" };
        Console.WriteLine("Ascending Selection sort");
        AscendingSelection<string>(stringArr);
        Console.WriteLine("Descending Selection sort");
        DescendingSelection<string>(stringArr);
        Console.WriteLine();

        char[] charArr = { 'c', 'a', 'f', 'b', 'k', 'h', 'z', 't', 'm', 'p', 'l', 'd' };
        Console.WriteLine("Ascending Selection sort");
        AscendingSelection<char>(charArr);
        Console.WriteLine("Descending Selection sort");
        DescendingSelection<char>(charArr);
        Console.WriteLine();
    }
    public static void AscendingSelection<Type>(Type[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int indexTemp = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (Comparer<Type>.Default.Compare(arr[indexTemp], arr[j]) > 0)
                {
                    indexTemp = j;
                }
            }
            Type temp = arr[i];
            arr[i] = arr[indexTemp];
            arr[indexTemp] = temp;
        }
        foreach (Type k in arr)
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine();
    }
    public static void DescendingSelection<Type>(Type[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int indexTemp = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (Comparer<Type>.Default.Compare(arr[indexTemp], arr[j]) < 0)
                {
                    indexTemp = j;
                }
            }
            Type temp = arr[i];
            arr[i] = arr[indexTemp];
            arr[indexTemp] = temp;
        }
        foreach (Type k in arr)
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine();
    }
}