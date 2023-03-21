namespace Assesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Main Loop to load get into selecting a road to read in.
            while (true)
            {
                // Beginning of error handling.
                try 
                {
                    //User chooses desired road to read into the program.
                    Console.WriteLine("What Road Do You Want To Choose? (1,2,3) or (4,5,6 which are Roads 1-3 with 2048 values.)");
                    int RoadNr = Convert.ToInt32(Console.ReadLine());
                    if (RoadNr < 0 || RoadNr > 6)
                    {
                        // If there is an invalid input, throw an exception. 
                        throw new Exception();
                    }
                    else
                    {
                        // If there is no error, continue and call the class Functions, and method Read of the respective value enetered by the user.
                        if (RoadNr == 1)
                        {
                            Functions.Read(1);
                        }
                        else if (RoadNr == 2)
                        {
                            Functions.Read(2);
                        }
                        else if (RoadNr == 3)
                        {
                            Functions.Read(3);
                        }
                        else if (RoadNr == 4)
                        {
                            Functions.Read(4);
                        }
                        else if (RoadNr == 5)
                        {
                            Functions.Read(5);
                        }
                        else if (RoadNr == 6)
                        {
                            Functions.Read(6);
                        }
                    }
                }
                catch
                {
                    // Catches the error and loops back to the start.
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                // Breaks the loop if no errors present.
                break;
            }
            // So that the program doesnt close unexpectedly and right after finishing.
            Console.WriteLine("Please press ENTER to exit.");
            Console.ReadLine();
        }
    }
}