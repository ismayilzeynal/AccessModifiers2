using AccessModifiers2.Models;
using System;

namespace AccessModifiers2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Singer LilNasX = new Singer
            {
                Name = "Montero",
                Surname = "Hill",
                Age = 23
            };

            Song OTR = new Song
            {
                Name = "Old Town Road",
                Genre = "Pop",
                Singer = LilNasX
            };

            Song Holiday = new Song
            {
                Name = "Holiday",
                Genre = "Pop",
                Singer = LilNasX
            };

            OTR.Addrating(9);
            OTR.Addrating(8);
            OTR.Addrating(10);
            OTR.Addrating(7);
            Console.WriteLine(OTR.GetAverageRating());

        }
    }
}
