using System;
using System.Collections.Generic;
using System.IO;

namespace Day3
{

    class Program
    {
        static HashSet<House> hashSet = new HashSet<House>();
        static int x_position = 0;
        static int y_position = 0;
        static int x_position_second = 0;
        static int y_position_second = 0;
        static void Main(string[] args)
        {
            string path = @"D:\Repozytoria\AdventOfCode\Day3\input.txt";
            char[] input = File.ReadAllText(path).ToCharArray();
            Console.WriteLine("Hello World!");
            hashSet.Add(new House(0, 0));
            foreach (char c in input)
            {
                switch (c)
                {
                    case '<':
                        y_position--;
                        break;
                    case '^':
                        x_position++;
                        break;
                    case '>':
                        y_position++;
                        break;
                    case 'v':
                        x_position--;
                        break;

                }
                hashSet.Add(new House(x_position, y_position));
            }
            Console.WriteLine($"First answer is : {hashSet.Count}");

            x_position = 0;
            y_position = 0;
            hashSet.Clear();
            hashSet.Add(new House(0,0));
            int counter = 0;
            foreach (char c in input)
            {
                if (counter % 2 == 0)
                {
                    switch (c)
                    {
                    case '<':
                        y_position--;
                        break;
                    case '^':
                        x_position++;
                        break;
                    case '>':
                        y_position++;
                        break;
                    case 'v':
                        x_position--;
                        break;
                    }
                    hashSet.Add(new House(x_position, y_position));
                }
                else
                {
                    switch (c)
                    {
                        case '<':
                            y_position_second--;
                            break;
                        case '^':
                            x_position_second++;
                            break;
                        case '>':
                            y_position_second++;
                            break;
                        case 'v':
                            x_position_second--;
                            break;

                    }
                    hashSet.Add(new House(x_position_second, y_position_second));
                }
                counter++;
            }
            Console.WriteLine($"Second answer is : {hashSet.Count}");
        }
    }

    class House
    {
        int x_position;
        int y_position;

        public House(int x_position, int y_position)
        {
            this.x_position = x_position;
            this.y_position = y_position;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            House house = (House)obj;
            return this.x_position == house.x_position && this.y_position == house.y_position;
        }

        public override int GetHashCode()
        {
            return x_position * 100 + y_position;
        }

    }



}
