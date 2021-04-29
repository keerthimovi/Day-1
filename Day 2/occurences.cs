
using System;
class occurences
{
static void Main()
    {
        string str = "Do you see what i see which other cant see";
        Console.WriteLine("Occurrence:" + Check.CheckOccurrences(str, "see"));
    }
}
public static class Check
{
 public static int CheckOccurrences(string sentences, string style)
    {
        int count = 0;
        int a = 0;
        while ((a = sentences.IndexOf(style, a)) != -1)
        {
            a += style.Length;
            count++;
        }
        return count;
    }
}