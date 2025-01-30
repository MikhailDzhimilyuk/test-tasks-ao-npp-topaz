using System;
using System.Collections.Generic;

public class Program
{
    private static void Main()
    {
        string data = "( Пгор || Ппик ) && ( (Gпол < 9000 && NY) > Ny_max_9000+0.1 || ( 9000 <= Gпол || Gпол < 10000 ) && NY > Ny_max_10000+0.1 || 10000 <= Gпол && NY > Ny_max_11100+0.1)";
        PrintSubstringsInParentheses(data);
    }

    private static void PrintSubstringsInParentheses(string data)
    {
        Stack<int> stack = new Stack<int>();
        List<(int start, int end)> results = new List<(int, int)>();

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == '(')
            {
                stack.Push(i);
            }
            else if (data[i] == ')')
            {
                if (stack.Count > 0)
                {
                    int start = stack.Pop();
                    results.Add((start + 1, i));
                }
            }
        }

        foreach (var result in results)
        {
            Console.WriteLine(data.Substring(result.start, result.end - result.start).Trim());
        }
    }
}