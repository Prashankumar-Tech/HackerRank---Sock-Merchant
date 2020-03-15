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

class Solution
{

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar)
    {
        int socksPairCount = 0;
        Dictionary<int, int> pairs = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            int item = 0;
            pairs.TryGetValue(ar[i], out item);
            if (item == 0)
            {
                pairs.Add(ar[i], 1);
            }
            else
            {
                pairs[ar[i]] = item + 1;
            }
        }
        foreach (KeyValuePair<int, int> entry in pairs)
        {
            socksPairCount = socksPairCount + (entry.Value / 2);

        }
        return socksPairCount;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
