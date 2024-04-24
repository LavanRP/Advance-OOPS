using System;
namespace LinearSearch;
public class Program
{
    public static void Main(string[] args)
    {
        int[] intArray = {45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        int findInt = 66;
        int positionInt = Linear<int>(intArray,findInt);

        string[] stringArray = {"SF3023","SF3021","SF3067","SF3043","SF3053","SF3032","SF3063","SF3089","SF3062","SF3092"};
        string findString = "SF3067";
        int positionString = Linear<string>(stringArray,findString);
        
        char[] charArray = {'c','a','f','b','k','h','j','I','i','z','t','m','p','l','d'};
        char findChar = 'm';
        int positionChar = Linear<char>(charArray,findChar);

        double[] doubleArray = {1.1,65.3,93.9,55.5,3.5,6.9 };
        double findDouble = 3.5;
        int positionDouble = Linear<double>(doubleArray,findDouble);

        Console.WriteLine($"in the int array element {findInt} present in {positionInt}th position");
        Console.WriteLine($"in the string array element {findString} present in {positionString}th position");
        Console.WriteLine($"in the char array element {findChar} present in {positionChar}th position");
        Console.WriteLine($"in the double array element {findDouble} present in {positionDouble}th position");
    }
    public static int Linear<Type>(Type[] arr,Type find)
    {
        int position  = -1;
        for(int i=0;i<arr.Length;i++)
        {
            if(arr[i].Equals(find))
            {
                position = i;
                break;
            }
        }
        return position;
    }
}