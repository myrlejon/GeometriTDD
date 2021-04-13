using System;

namespace GeometriTDD
{
    class Program
    {
        static void Main(string[] args)
        {
            var sq = new Triangle(6);
            Console.WriteLine($"Triangels area: {sq.OmkretsLiksig()}");
        }
    }
}
