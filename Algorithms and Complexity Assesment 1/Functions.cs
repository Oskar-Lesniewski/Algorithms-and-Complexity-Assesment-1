namespace Assesment1
{
    public class Functions
    {
        public static bool Read(int RoadNr)
        {
            if (RoadNr == 1)
            {
                string[] lines = File.ReadAllLines("Road_1_256.txt");
                int[] Road = Array.ConvertAll(lines, int.Parse);
                int[] RoadUS = Array.ConvertAll(lines, int.Parse);
                int Increment = 10;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("To Merge Roads 1 and 3 type (1), To continue with just this Road type (0). ");
                        int Merged = Convert.ToInt32(Console.ReadLine());
                        if (Merged < 0 || Merged > 1)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            if (Merged == 1)
                            {
                                string[] linesToMerge = File.ReadAllLines("Road_3_256.txt");
                                int[] RoadToMerge = Array.ConvertAll(linesToMerge, int.Parse);
                                Merge(Road, RoadToMerge, Increment);
                            }
                            else if (Merged == 0)
                            {
                                SortSearch(Road, RoadUS, Increment);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input try again.");
                        continue;
                    }
                    break;
                }
            }

            else if (RoadNr == 2)
            {
                string[] lines = File.ReadAllLines("Road_2_256.txt");
                int[] Road = Array.ConvertAll(lines, int.Parse);
                int[] RoadUS = Array.ConvertAll(lines, int.Parse);
                int Increment = 10;
                SortSearch(Road, RoadUS, Increment);
            }
            else if (RoadNr == 3)
            {
                string[] lines = File.ReadAllLines("Road_3_256.txt");
                int[] Road = Array.ConvertAll(lines, int.Parse);
                int[] RoadUS = Array.ConvertAll(lines, int.Parse);
                int Increment = 10;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("To Merge Roads 3 and 1 type (1), To continue with just this Road type (0). ");
                        int Merged = Convert.ToInt32(Console.ReadLine());
                        if (Merged < 0 || Merged > 1)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            if (Merged == 1)
                            {
                                string[] linesToMerge = File.ReadAllLines("Road_1_256.txt");
                                int[] RoadToMerge = Array.ConvertAll(linesToMerge, int.Parse);
                                Merge(Road, RoadToMerge, Increment);
                            }
                            else if (Merged == 0)
                            {
                                SortSearch(Road, RoadUS, Increment);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input try again.");
                        continue;
                    }
                    break;
                }
            }
            else if (RoadNr == 4)
            {
                string[] lines = File.ReadAllLines("Road_1_2048.txt");
                int[] Road = Array.ConvertAll(lines, int.Parse);
                int[] RoadUS = Array.ConvertAll(lines, int.Parse);
                int Increment = 50;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("To Merge Roads 1 and 3 type (1), To continue with just this Road type (0). ");
                        int Merged = Convert.ToInt32(Console.ReadLine());
                        if (Merged < 0 || Merged > 1)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            if (Merged == 1)
                            {
                                string[] linesToMerge = File.ReadAllLines("Road_3_2048.txt");
                                int[] RoadToMerge = Array.ConvertAll(linesToMerge, int.Parse);
                                Merge(Road, RoadToMerge, Increment);
                            }
                            else if (Merged == 0)
                            {
                                SortSearch(Road, RoadUS, Increment);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input try again.");
                        continue;
                    }
                    break;
                }
            }

            else if (RoadNr == 5)
            {
                string[] lines = File.ReadAllLines("Road_2_2048.txt");
                int[] Road = Array.ConvertAll(lines, int.Parse);
                int[] RoadUS = Array.ConvertAll(lines, int.Parse);
                int Increment = 50;
                SortSearch(Road, RoadUS, Increment);
            }
            else if (RoadNr == 6)
            {
                string[] lines = File.ReadAllLines("Road_3_2048.txt");
                int[] Road = Array.ConvertAll(lines, int.Parse);
                int[] RoadUS = Array.ConvertAll(lines, int.Parse);
                int Increment = 50;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("To Merge Roads 3 and 1 type (1), To continue with just this Road type (0). ");
                        int Merged = Convert.ToInt32(Console.ReadLine());
                        if (Merged < 0 || Merged > 1)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            if (Merged == 1)
                            {
                                string[] linesToMerge = File.ReadAllLines("Road_1_2048.txt");
                                int[] RoadToMerge = Array.ConvertAll(linesToMerge, int.Parse);
                                Merge(Road, RoadToMerge, Increment);
                            }
                            else if (Merged == 0)
                            {
                                SortSearch(Road, RoadUS, Increment);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input try again.");
                        continue;
                    }
                    break;
                }
            }
            else
            {
                return false;
            }
            
            return false;
        }
        public static bool Merge(int[] Road1, int[] Road2, int Increment)
        {
            var TempList = new List<int>();
            TempList.AddRange(Road1);
            TempList.AddRange(Road2);
            int[] RoadMerged = TempList.ToArray();
            int[] RoadUSMerged = TempList.ToArray(); 
            SortSearch(RoadMerged, RoadUSMerged, Increment);
            return false;
        }
        public static bool SortSearch(int[] Road, int[] RoadUS, int Increment)
        {
            int i = 0;
            int length = Road.Length;
            while (true)
            {
                try
                {
                    Console.WriteLine("Ascending (1) or Descending (2) sort?");
                    int ArrDir = Convert.ToInt32(Console.ReadLine());
                    if (ArrDir < 1 || ArrDir > 2)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        string Dir = "Unsorted";
                        if (ArrDir == 1)
                        {
                            Dir = "Ascending";
                            for (int x = 0; x < length - 1; x++)
                            {
                                for (int y = 0; y < length - x - 1; y++)
                                {
                                    if (Road[y] > Road[y + 1])
                                    {
                                        int Temp = Road[y];
                                        Road[y] = Road[y + 1]; // reference lecture code, bubble sort, or https://code-maze.com/csharp-bubble-sort/
                                        Road[y + 1] = Temp;
                                    }
                                }
                            }
                        }
                        else if (ArrDir == 2)
                        {
                            Dir = "Descending";
                            for (int x = 0; x < length - 1; x++)
                            {
                                for (int y = 0; y < length - x - 1; y++)
                                {
                                    if (Road[y] < Road[y + 1])
                                    {
                                        int Temp = Road[y];
                                        Road[y] = Road[y + 1];
                                        Road[y + 1] = Temp;
                                    }
                                }
                            }
                        }
                        Console.WriteLine("The data has been sorted in " + Dir + " order.");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
            }        
            for (i = 0; i < Road.Length; i += Increment)
            {
                if (i == 0)
                {
                    Console.WriteLine(Road[i] + " This is the first value");
                }
                else
                {
                    Console.WriteLine(Road[i - 1] + " This is " + i + "th value");
                }
            }
            // Searching
            while (true)
            {
                try
                {
                    Console.WriteLine("Do you want to find a value in the Sorted (1) or Unsorted (2) array?");
                    int SearchType = Convert.ToInt32(Console.ReadLine());
                    if (SearchType < 1 || SearchType > 2)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        int[] ArrType = { };
                        if (SearchType == 1)
                        {
                            ArrType = Road;
                        }
                        else if (SearchType == 2)
                        {
                            ArrType = RoadUS;
                        }
                        int Max = ArrType.Max();
                        int Min = ArrType.Min();
                        try
                        {
                            Console.WriteLine("Enter a number you want to find in the data between " + Min + " - " + Max);
                            int Selected = Convert.ToInt32(Console.ReadLine());
                            if (Selected < Min || Selected > Max)
                            {
                                throw new Exception();
                            }
                            else
                            {
                                int FoundValue = -1;
                                int FoundValueIndex = -1;
                                bool WasFound = false;
                                for (int z = 0; z < ArrType.Length; z++)
                                {
                                    if (Selected == ArrType[z])
                                    {
                                        FoundValue = ArrType[z]; // Reference lecture code, sequential search
                                        FoundValueIndex = z + 1;
                                        Console.WriteLine("The value was found at position " + FoundValueIndex + " and the value found was " + FoundValue);
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
                                    ClosestValue = ArrType.OrderBy(v => Math.Abs(v - Selected)).First(); // Used code here, https://stackoverflow.com/questions/41277957/get-closest-value-in-an-array
                                    ClosestIndex = Array.IndexOf(ArrType, ClosestValue);
                                    Console.WriteLine("The value was not found, but the closest one is " + ClosestValue + " in the position " + (ClosestIndex + 1));
                                }
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Inalid input try again.");
                            continue;
                        }
                    }                       
                }
                catch
                {
                    Console.WriteLine("Inalid input try again.");
                    continue;
                }
            }            
            return false;
        }
        

    }
}