using System.Security.Cryptography;
using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;

class Program
{
    static string input = "iwrupvqb";
    static MD5 md5Bytes = MD5.Create();
    static void Main()
    {
        int i = 0;
        while (1 < int.MaxValue)
        {
            if (DoesMatch(TryHash(i)))
                break;
            i++;
        }
        Console.WriteLine(i);
        Console.WriteLine(TryHash(i));

        while (1 < int.MaxValue)
        {
            if (DoesMatchForSix(TryHash(i)))
                break;
            i++;
        }
        Console.WriteLine(i);
        Console.WriteLine(TryHash(i));
    }

    static string TryHash(int i)
    {
        var sourceBytes = Encoding.UTF8.GetBytes(input+i);
        var hashBytes = md5Bytes.ComputeHash(sourceBytes);
        return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
    }

    static bool DoesMatch(string str)
    {
        if (new Regex("^00000.").IsMatch(str))
            return true;
        return false;
    }

    static bool DoesMatchForSix(string str)
    {
        if (new Regex("^000000.").IsMatch(str))
            return true;
        return false;
    }
}