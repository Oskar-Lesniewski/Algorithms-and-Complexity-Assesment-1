namespace Assesment1
{
    // Class containing all the codes functionality.
    public class Functions
    {
        // Method that takes the user input from the main program to read in correct files.
        public static bool Read(int RoadNr)
        {
            if (RoadNr == 1)
            {
                // Reads in respective file into the program into an array.
                string[] lines = File.ReadAllLines("Road_1_256.txt");
                int[] Road = Array.ConvertAll(lines, int.Parse);
                // Unsorted array which is a copy, for use later on if needed.
                int[] RoadUS = Array.ConvertAll(lines, int.Parse);
                // Sets an increment which will be needed later on.
                int Increment = 10;
                while (true)
                {
                    try
                    {
                        // User has option to merge Roads 1 and 3.
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
                                // Reads in Road 3.
                                string[] linesToMerge = File.ReadAllLines("Road_3_256.txt");
                                int[] RoadToMerge = Array.ConvertAll(linesToMerge, int.Parse);
                                // Calls merge method to merge Roads 1 and 3 into one array.
                                Merge(Road, RoadToMerge, Increment);
                            }
                            else if (Merged == 0)
                            {
                                // Continues without merging, calls the SortSearch method.
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
        // Method used for merging Roads 1 and 3.
        public static bool Merge(int[] Road1, int[] Road2, int Increment)
        {
            // Creates a TempList, which gets all the values from both arrays added.
            var TempList = new List<int>();
            TempList.AddRange(Road1);
            TempList.AddRange(Road2);
            // The list gets put into an array.
            int[] RoadMerged = TempList.ToArray();
            // Also generates an unsorted version, for use later on if needed.
            int[] RoadUSMerged = TempList.ToArray(); 
            // Calls SortSearch with new values.
            SortSearch(RoadMerged, RoadUSMerged, Increment);
            return false;
        }
        // Method that will sort and search through the array in various ways. 
        public static bool SortSearch(int[] Road, int[] RoadUS, int Increment)
        {
            int Length = Road.Length;
            while (true)
            {
                try
                {
                    // User can decide to have an Ascending or Descending sort.
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
                            // Ascending Bubble Sort.
                            Dir = "Ascending";
                            for (int x = 0; x < Length - 1; x++)
                            {
                                for (int y = 0; y < Length - x - 1; y++)
                                {
                                    if (Road[y] > Road[y + 1])
                                    {
                                        int Temp = Road[y];
                                        Road[y] = Road[y + 1];
                                        Road[y + 1] = Temp;
                                    }
                                }
                            }
                        }
                        else if (ArrDir == 2)
                        {
                            // Descending Bubble Sort.
                            Dir = "Descending";
                            for (int x = 0; x < Length - 1; x++)
                            {
                                for (int y = 0; y < Length - x - 1; y++)
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
                        // Tells the user the direction the array has been sorted in.
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
            // Loop to display every 10 or 50 values depending on the amount of road values.
            for (int i = 0; i < Road.Length; i += Increment)
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
            // Searching section of code.
            while (true)
            {
                try
                {
                    // Asks user if they want to find values in the Sorted or Unsorted arrays.
                    Console.WriteLine("Do you want to find a value in the Sorted (1) or Unsorted (2) array?");
                    int SearchType = Convert.ToInt32(Console.ReadLine());
                    if (SearchType < 1 || SearchType > 2)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        int[] ArrType = Array.Empty<int>();
                        if (SearchType == 1)
                        {
                            ArrType = Road;
                        }
                        else if (SearchType == 2)
                        {
                            // Replaces sorted Road with unsorted.
                            ArrType = RoadUS;
                        }
                        int Max = ArrType.Max();
                        int Min = ArrType.Min();
                        try
                        {
                            // User enters value they wish to find in the array.
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
                                int Amount = 0;
                                // Sequential search to find the users value.
                                for (int Checked = 0; Checked < ArrType.Length; Checked++)
                                {
                                    if (Selected == ArrType[Checked])
                                    {
                                        Amount++;
                                        FoundValue = ArrType[Checked];
                                        FoundValueIndex = Checked + 1;
                                        // Tells user position of desired value.
                                        Console.WriteLine("The value was found at position " + FoundValueIndex + " and the value found was " + FoundValue);
                                        WasFound = true;
                                        continue;
                                    }
                                    else
                                    {
                                        FoundValue = -1;
                                    }
                                }
                                Console.WriteLine("The desired value was found " + Amount + " times.");
                                int ClosestValue = -1;
                                int ClosestIndex = -1;
                                // Displays closest value to the desired value if desired value not found.
                                if (FoundValue == -1 && WasFound == false)
                                {
                                    ClosestValue = ArrType[0];
                                    int difference = Math.Abs(Selected - ClosestValue);
                                    for (int i = 1; i < ArrType.Length; i++)
                                    {
                                        int currentDifference = Math.Abs(Selected - ArrType[i]);
                                        if (currentDifference < difference)
                                        {
                                            ClosestValue = ArrType[i];
                                        }
                                    }
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