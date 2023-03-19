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
        public static bool Functionality(int RoadNr)
        {
            if (RoadNr == 1)
            {
                string[] lines = File.ReadAllLines("Road_1_256.txt");
                int i = 0;
                int[] Road1 = Array.ConvertAll(lines, int.Parse);
                int[] Road1US = Array.ConvertAll(lines, int.Parse);
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
                string Dir = "Unsorted";
                if (ArrDir == 1)
                {
                    Dir = "Ascending";
                }
                else if (ArrDir == 2)
                {
                    Dir = "Descending";
                    Array.Reverse(Road1);
                }
                Console.WriteLine("The data has been sorted in " + Dir + " order.");
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
                // Searching
                Console.WriteLine("Do you want to find a value ihe sorted or unsorted array? 1 or 2 respecively?");
                int SearchType = Convert.ToInt32(Console.ReadLine());
                int[] ArrType = { };
                if (SearchType == 1)
                {
                    ArrType = Road1;
                }
                else if (SearchType == 2)
                {
                    ArrType = Road1US;
                }
                int Max = ArrType.Max();
                int Min = ArrType.Min();
                Console.WriteLine("Enter a number you want to find in the data between " + Min + " - " + Max);
                int Selected = Convert.ToInt32(Console.ReadLine());
                int FoundValue = -1;
                int FoundValueIndex = -1;
                bool WasFound = false;
                for (int z = 0; z < ArrType.Length; z++)
                {
                    if (Selected == ArrType[z])
                    {
                        FoundValue = ArrType[z];
                        FoundValueIndex = z + 1;
                        Console.WriteLine("The value was found at index " + FoundValueIndex + " and the value was " + FoundValue);
                        WasFound = true;
                        continue;
                    }
                    else
                    {
                        FoundValue = -1;
                    }
                }
                int ClosestValue = -1;
                int ClosestIndex = -1;
                if (FoundValue == -1 && WasFound == false)
                {
                    ClosestValue = ArrType.OrderBy(v => Math.Abs(v - Selected)).First();
                    ClosestIndex = Array.IndexOf(ArrType, ClosestValue);
                    Console.WriteLine("The value was not found, but the closest one is " + ClosestValue + " in the index position " + (ClosestIndex + 1));
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
                string Dir = "Unsorted";
                if (ArrDir == 1)
                {
                    Dir = "Ascending";
                    Console.WriteLine("The data has been sorted in " + Dir + " order.");
                }
                else if (ArrDir == 2)
                {
                    Dir = "Descending";
                    Array.Reverse(Road1);
                    Console.WriteLine("The data has been sorted in " + Dir + " order.");
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