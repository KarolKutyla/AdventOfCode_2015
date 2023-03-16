// See https://aka.ms/new-console-template for more information

using System.Net;

public static class Day1Class
{
    static int currentFlor = 0;
    static int counter = 0;
    public static void Main(string[] args)
    {
        string path = @"C:\Users\karol\source\repos\AdventOfCode_2015\Day1Class\input_1.txt";
        //Console.WriteLine(path);
        string content = File.ReadAllText(path);
        //Console.WriteLine(content);
        foreach(char c in content.ToCharArray())
        {
            counter++;
            if(c == '(')
            {
                currentFlor++;
            }else if (c == ')')
            {
                currentFlor--;
            }
            if (currentFlor < 0)
                break;
        }
        Console.WriteLine($"Current flor: {currentFlor}, Counter: {counter};");
    } 

}