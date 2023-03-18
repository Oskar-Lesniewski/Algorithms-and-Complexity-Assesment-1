using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace Assesment1
{
    public class Reading
    {
        public static bool Read(int RoadNr)
        {
            if (RoadNr == 1)
            {
                string[] lines = File.ReadAllLines("Road_1_256.txt");
                int i = 0;
                int[] Road1 = Array.ConvertAll(lines, int.Parse);
                int length = Road1.Length;
                for (int x = 0; x < length - 1; x++)
                {
                    for (int y = 0; y < length - x - 1; y++)
                    {
                        if (Road1[y] > Road1[y + 1])
                        {
                            int temp = Road1[y];
                            Road1[y] = Road1[y + 1];
                            Road1[y + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Ascending (1) or Descending (2) sort?");
                int ArrDir = Convert.ToInt32(Console.ReadLine());
                if (ArrDir == 1)
                {
                    Console.WriteLine();
                }
                else if (ArrDir == 2)
                {
                    Array.Reverse(Road1);
                }
                for (i = 0; i < Road1.Length; i += 10)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(Road1[i] + " This is the first value");
                    }
                    else
                    {
                        Console.WriteLine(Road1[i - 1] + " This is " + i + "th value");
                    }
                }
            }
            else if (RoadNr == 2)
            {
                string[] lines = File.ReadAllLines("Road_2_256.txt");
                int i = 0;
                int[] Road2 = Array.ConvertAll(lines, int.Parse);
                int length = Road2.Length;
                for (int x = 0; x < length - 1; x++)
                {
                    for (int y = 0; y < length - x - 1; y++)
                    {
                        if (Road2[y] > Road2[y + 1])
                        {
                            int temp = Road2[y];
                            Road2[y] = Road2[y + 1];
                            Road2[y + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Ascending (1) or Descending (2) sort?");
                int ArrDir = Convert.ToInt32(Console.ReadLine());
                if (ArrDir == 1)
                {
                    Console.WriteLine();
                }
                else if (ArrDir == 2)
                {
                    Array.Reverse(Road2);
                }
                for (i = 0; i < Road2.Length; i += 10)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(Road2[i] + " This is the first value");
                    }
                    else
                    {
                        Console.WriteLine(Road2[i - 1] + " This is " + i + "th value");
                    }
                }
            }
            else if (RoadNr == 3)
            {
                string[] lines = File.ReadAllLines("Road_3_256.txt");
                int i = 0;
                int[] Road1 = Array.ConvertAll(lines, int.Parse);
                int length = Road1.Length;
                for (int x = 0; x < length - 1; x++)
                {
                    for (int y = 0; y < length - x - 1; y++)
                    {
                        if (Road1[y] > Road1[y + 1])
                        {
                            int temp = Road1[y];
                            Road1[y] = Road1[y + 1];
                            Road1[y + 1] = temp;
                        }
                    }
                }
                Console.WriteLine("Ascending (1) or Descending (2) sort?");
                int ArrDir = Convert.ToInt32(Console.ReadLine());
                if (ArrDir == 1)
                {
                    Console.WriteLine();
                }
                else if (ArrDir == 2)
                {
                    Array.Reverse(Road1);
                }
                for (i = 0; i < Road1.Length; i += 10)
                {
                    if (i == 0)
                    {
                        Console.WriteLine(Road1[i] + " This is the first value");
                    }
                    else
                    {
                        Console.WriteLine(Road1[i - 1] + " This is " + i + "th value");
                    }
                }
            }
            else
            {
                return false;
            }
            return false;
        }
        

    }
}