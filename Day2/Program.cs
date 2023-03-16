// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        long sum = 0;
        string path = @"C:\Users\karol\source\repos\AdventOfCode_2015\Day2\output.txt";
        StreamReader reader = File.OpenText(path);
        string line;
        while((line = reader.ReadLine()) != null)
        {
            string[] tab = line.Split('x');
            int[] intTab = new int[3];
            Parse(tab, intTab);
            sum += ReturnField2(intTab);
            //System.Console.WriteLine(ReturnField(intTab));
        }
        System.Console.WriteLine(sum);
    }

    static void Parse(string[] strTab, int[] intTab)
    {
        for(int i = 0; i < 3; i++)
        {
            System.Console.WriteLine(strTab[i]);
            intTab[i] = int.Parse(strTab[i]);
        }
        Array.Sort(intTab);
    }

    static int ReturnField(int[] tab)
    {
        System.Console.WriteLine(tab[0] + " " + tab[1] + " " + tab[2]);
        return tab[0] * tab[1] * 3 + tab[0] * tab[2] * 2 + tab[1] * tab[2] * 2;
    }

    static int ReturnField2(int[] tab)
    {
        System.Console.WriteLine(tab[0] + " " + tab[1] + " " + tab[2]);
        return tab[0] * tab[1] * tab[2] + tab[0] * 2 + tab[1] * 2;
    }
}
