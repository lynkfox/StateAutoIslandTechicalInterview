using System;
using StateAutoTechnicalInterview;

namespace Wrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] testGrid1 = new int[,] { { 1, 1, 1, 1, 0 }, { 1, 1, 0, 1, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

            int[,] testGrid2 = new int[,] { { 1, 1, 0, 1, 0 }, { 0, 0, 0, 1, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

            Map firstMap = new Map(testGrid1);
            Map secondMap = new Map(testGrid2);

            Console.Write("The First map has {0} islands", firstMap.Search());
            Console.WriteLine("The Second map has {0} islands", secondMap.Search());
        }
    }
}
