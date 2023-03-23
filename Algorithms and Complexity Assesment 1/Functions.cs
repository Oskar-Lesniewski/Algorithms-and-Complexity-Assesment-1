using System.Collections.Generic;

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
                    Console.WriteLine("Bubble Sort (1) or Insertion Sort (2) or Merge Sort (3) or Quick Sort (4)?");
                    int SortType = Convert.ToInt32(Console.ReadLine());
                    if (ArrDir < 1 || ArrDir > 2)
                    {
                        throw new Exception();
                    }
                    else if (SortType < 1 || SortType > 4)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        string Dir = "Unsorted";
                        string SortedIn = "None";
                        if (ArrDir == 1 && SortType == 1)
                        {
                            // Ascending Bubble Sort.
                            Dir = "Ascending";
                            SortedIn = "Bubble Sort";
                            BubbleSort(Road, Length, ArrDir);
                        }
                        else if (ArrDir == 2 && SortType == 1)
                        {
                            // Descending Bubble Sort.
                            Dir = "Descending";
                            SortedIn = "Bubble Sort";
                            BubbleSort(Road, Length, ArrDir);
                        }
                        else if (ArrDir == 1 && SortType == 2)
                        {
                            // Ascending Insertion Sort
                            Dir = "Ascending";
                            SortedIn = "Insertion Sort";
                            InsertionSort(Road, Length, ArrDir);
                        }
                        else if (ArrDir == 2 && SortType == 2)
                        {
                            // Descending Insertion Sort
                            Dir = "Descending";
                            SortedIn = "Insertion Sort";
                            InsertionSort(Road, Length, ArrDir);
                        }
                        else if (ArrDir == 1 && SortType == 3)
                        {
                            // Ascending Merge Sort
                            Dir = "Ascending";
                            SortedIn = "Merge Sort";
                            MergeSort(Road, 0, Road.Length - 1, ArrDir);
                        }
                        else if (ArrDir == 2 && SortType == 3)
                        {
                            // Descending Merge Sort
                            Dir = "Descending";
                            SortedIn = "Merge Sort";
                            MergeSort(Road, 0, Road.Length - 1, ArrDir);
                        }
                        else if (ArrDir == 1 && SortType == 4)
                        {
                            // Ascending Quick Sort
                            Dir = "Ascending";
                            SortedIn = "Quick Sort";
                            QuickSort(Road, 0, Road.Length - 1, ArrDir);
                        }
                        else if (ArrDir == 2 && SortType == 4)
                        {
                            // Descending Quick Sort
                            Dir = "Descending";
                            SortedIn = "Quick Sort";
                            QuickSort(Road, 0, Road.Length - 1, ArrDir);
                        }
                        else
                        {
                            Console.WriteLine("You entered an incorrect combination, try again.");
                            throw new Exception();
                        }
                        // Tells the user the direction the array has been sorted in.
                        Console.WriteLine("The data has been sorted in " + Dir + " order using the Sort " + SortedIn);
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
                            Console.WriteLine("Sequential (1) or Binary (2) Search (Can only use binary on sorted data, and will only find first value, no duplicates.) ");
                            int SortWanted = Convert.ToInt32(Console.ReadLine());
                            if (Selected < Min || Selected > Max)
                            {
                                throw new Exception();
                            }
                            if (SortWanted < 1 || SortWanted > 2)
                            {
                                throw new Exception();
                            }
                            else
                            {
                                int FoundValue = -1;
                                int FoundValueIndex = -1;
                                bool WasFound = false;
                                if (SortWanted == 1)
                                {
                                    // Sequential Search taken from https://learn-eu-central-1-prod-fleet01-xythos.content.blackboardcdn.com/5eec76bac93d5/10243307?X-Blackboard-S3-Bucket=learn-eu-central-1-prod-fleet01-xythos&X-Blackboard-Expiration=1679529600000&X-Blackboard-Signature=3rW7l8gOCUrHv7XvxCGT0THwRNy9AoLl306heDSdfLk%3D&X-Blackboard-Client-Id=307403&X-Blackboard-S3-Region=eu-central-1&response-cache-control=private%2C%20max-age%3D21600&response-content-disposition=inline%3B%20filename%2A%3DUTF-8%27%27CMP1124M_Lecture_5_Searching%2526Sorting1.pdf
                                    // Sequential search to find the users value.
                                    for (int Checked = 0; Checked < ArrType.Length; Checked++)
                                    {
                                        if (Selected == ArrType[Checked])
                                        {
                                            // Checks Each Value
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
                                }
                                else if (SortWanted == 2 && SearchType == 1)
                                {
                                    // Binary Search inspired from https://csharpexamples.com/c-binary-search-example/ 
                                    // Binary Search
                                    int left = 0;
                                    int right = ArrType.Length - 1;
                                    while (left <= right)
                                    {
                                        int mid = left + (right - left) / 2;

                                        if (ArrType[mid] == Selected)
                                        {
                                            FoundValue = ArrType[mid];
                                            FoundValueIndex = mid + 1;
                                            Console.WriteLine("The value was found at position " + FoundValueIndex + " and the value found was " + FoundValue);
                                            break;
                                        }

                                        if (ArrType[mid] < Selected)
                                        {
                                            left = mid + 1;
                                        }
                                        else
                                        {
                                            right = mid - 1;
                                        }
                                    }

                                    if (FoundValue == -1)
                                    {
                                        Console.WriteLine("The desired value was not found.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Something went wrong, try again.");
                                    throw new Exception();
                                }
                                int ClosestValue = -1;
                                int ClosestIndex = -1;
                                // Displays closest value to the desired value if desired value not found.
                                if (FoundValue == -1 && WasFound == false)
                                {
                                    ClosestValue = ArrType[0];
                                    int Difference = Math.Abs(Selected - ClosestValue);
                                    for (int i = 1; i < ArrType.Length; i++)
                                    {
                                        int DifferenceNow = Math.Abs(Selected - ArrType[i]);
                                        if (DifferenceNow < Difference)
                                        {
                                            ClosestValue = ArrType[i];
                                            Difference = DifferenceNow;
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
        // Bubble sort method taken from https://learn-eu-central-1-prod-fleet01-xythos.content.blackboardcdn.com/5eec76bac93d5/10243307?X-Blackboard-S3-Bucket=learn-eu-central-1-prod-fleet01-xythos&X-Blackboard-Expiration=1679529600000&X-Blackboard-Signature=3rW7l8gOCUrHv7XvxCGT0THwRNy9AoLl306heDSdfLk%3D&X-Blackboard-Client-Id=307403&X-Blackboard-S3-Region=eu-central-1&response-cache-control=private%2C%20max-age%3D21600&response-content-disposition=inline%3B%20filename%2A%3DUTF-8%27%27CMP1124M_Lecture_5_Searching%2526Sorting1.pdf
        public static void BubbleSort(int[] Road, int Length, int ArrDir)
        {
            if (ArrDir == 1)
            {
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
        }
        // Insertion Sort taken from https://learn-eu-central-1-prod-fleet01-xythos.content.blackboardcdn.com/5eec76bac93d5/10243307?X-Blackboard-S3-Bucket=learn-eu-central-1-prod-fleet01-xythos&X-Blackboard-Expiration=1679529600000&X-Blackboard-Signature=3rW7l8gOCUrHv7XvxCGT0THwRNy9AoLl306heDSdfLk%3D&X-Blackboard-Client-Id=307403&X-Blackboard-S3-Region=eu-central-1&response-cache-control=private%2C%20max-age%3D21600&response-content-disposition=inline%3B%20filename%2A%3DUTF-8%27%27CMP1124M_Lecture_5_Searching%2526Sorting1.pdf
        public static void InsertionSort(int[] Road, int Length, int ArrDir)
        {
            int SortedNum = 1;
            int Index;
            while (SortedNum < Length)
            {
                int temp = Road[SortedNum];
                if (ArrDir == 1)
                {
                    for (Index = SortedNum; Index > 0; Index--)
                    {
                        if (temp < Road[Index - 1])
                        {
                            Road[Index] = Road[Index - 1];
                        }
                        else
                        {
                            break;
                        }
                    }
                    Road[Index] = temp;
                    SortedNum++;
                }
                else if (ArrDir == 2)
                {
                    for (Index = SortedNum; Index > 0; Index--)
                    {
                        if (temp > Road[Index - 1])
                        {
                            Road[Index] = Road[Index - 1];
                        }
                        else
                        {
                            break;
                        }
                    }
                    Road[Index] = temp;
                    SortedNum++;
                }
            }
        }
        // Merge Sort taken from https://csharpexamples.com/c-merge-sort-algorithm-implementation/
        public static void MergeSort(int[] Input, int Left, int Right, int ArrDir)
        {
            if (Left < Right)
            {
                int Middle = (Left + Right) / 2;

                MergeSort(Input, Left, Middle, ArrDir);
                MergeSort(Input, Middle + 1, Right, ArrDir);

                Merging(Input, Left, Middle, Right, ArrDir);
            }
        }
        public static void Merging(int[] Input, int Left, int Middle, int Right, int ArrDir)
        {
            int[] leftArray = new int[Middle - Left + 1];
            int[] rightArray = new int[Right - Middle];

            Array.Copy(Input, Left, leftArray, 0, Middle - Left + 1);
            Array.Copy(Input, Middle + 1, rightArray, 0, Right - Middle);

            int i = 0;
            int j = 0;
            if (ArrDir == 1)
            {
                for (int k = Left; k < Right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        Input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        Input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        Input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        Input[k] = rightArray[j];
                        j++;
                    }
                }
            }
            else if (ArrDir == 2)
            {
                for (int k = Left; k < Right + 1; k++)
                {
                    if (i == leftArray.Length)
                    {
                        Input[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        Input[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] >= rightArray[j])
                    {
                        Input[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        Input[k] = rightArray[j];
                        j++;
                    }
                }
            }
        }
        // Quick Sort taken from https://csharpexamples.com/c-quick-sort-algorithm-implementation/
        public static void QuickSort(int[] Road, int Start, int End, int ArrDir)
        {
            int i;
            if (Start < End)
            {
                i = Partition(Road, Start, End, ArrDir);

                QuickSort(Road, Start, i - 1, ArrDir);
                QuickSort(Road, i + 1, End, ArrDir);
            }
        }
        public static int Partition(int[] Road, int Start, int End, int ArrDir)
        {
            int temp;
            int p = Road[End];
            int i = Start - 1;
            if (ArrDir == 1)
            {
                for (int j = Start; j <= End - 1; j++)
                {
                    if (Road[j] <= p)
                    {
                        i++;
                        temp = Road[i];
                        Road[i] = Road[j];
                        Road[j] = temp;
                    }
                }
            }
            else if (ArrDir == 2)
            {
                for (int j = Start; j <= End - 1; j++)
                {
                    if (Road[j] >= p)
                    {
                        i++;
                        temp = Road[i];
                        Road[i] = Road[j];
                        Road[j] = temp;
                    }
                }
            }
            temp = Road[i + 1];
            Road[i + 1] = Road[End];
            Road[End] = temp;
            return i + 1;
        }
    }
}