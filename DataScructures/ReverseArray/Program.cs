using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ReverseArray;
// class Result
// {

//     /*
//      * Complete the 'reverseArray' function below.
//      *
//      * The function is expected to return an INTEGER_ARRAY.
//      * The function accepts INTEGER_ARRAY a as parameter.
//      */

//     public static List<int> reverseArray(List<int> a)
//     {
//         return a;
//     }

// }

public class Program {

    public static void Main(string[] args)
    {
        List<int> a = new List<int>() { 1, 2, 3, 4 };
        List<int> reversedArray = new List<int>(4);
        int cont = 0;
        

        for (int i = 0; i < a.Count; i++) {
            Console.WriteLine($"i: {i} | cont: {cont} | a[i]: {a[i]}");
            reversedArray[i] = a[a.Count - i];
            Console.WriteLine(reversedArray[cont]);
            cont++;
        }

        reversedArray.RemoveAt(0);
        
        for (int i = 0; i < reversedArray.Count; i++) {
            Console.WriteLine(reversedArray[i]);
        }

        
    }
}

// class Solution
// {
//     public static void Main(string[] args)
//     {
//         TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//         int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

//         List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//         List<int> res = Result.reverseArray(arr);

//         textWriter.WriteLine(String.Join(" ", res));

//         textWriter.Flush();
//         textWriter.Close();
//     }
// }
