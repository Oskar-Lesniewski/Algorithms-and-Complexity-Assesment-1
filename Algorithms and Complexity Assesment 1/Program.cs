using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assesment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Road Do You Want To Choose? 1,2,3");
            int RoadNr = Convert.ToInt32(Console.ReadLine());
            if (RoadNr == 1)
            {
                Reading.Read(1);
            }
            else if (RoadNr == 2)
            {
                Reading.Read(2);
            }
            else if (RoadNr == 3)
            {
                Reading.Read(3);
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadLine();
        }
    }
}