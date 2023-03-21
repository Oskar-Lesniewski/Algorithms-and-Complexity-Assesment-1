namespace Assesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("What Road Do You Want To Choose? (256 Values Enter 1,2,3 for each respective road.) (2048 Values Enter 4,5,6 for each respective road.)");
                    int RoadNr = Convert.ToInt32(Console.ReadLine());
                    if (RoadNr < 0 || RoadNr > 6)
                    {
                        throw new Exception();
                    }
                    else
                    {
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
                    Console.WriteLine("Invalid input try again.");
                    continue;
                }
                break;
            }
            Console.WriteLine("Please press ENTER to exit.");
            Console.ReadLine();
        }
    }
}