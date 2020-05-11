using Microsoft.VisualStudio.TestTools.UnitTesting;
using StateAutoTechnicalInterview;

namespace InterviewTestingSpace
{
    [TestClass]
    public class UnitTest1
    {
        /* Given a Grid of 1's and 0's, where 1 equals Land and 0 equals water, determine how many islands there are.
         * 
         * An island counts as all the connected 1's on a grid.
         * 
         * All edge spaces are considered 0's

        

        /* Test Grid 1
        11110
        11010
        11000
        00000
        */

        /* Test Grid 2
        11010
        00010
        11000
        00000
        */
        int[,] testGrid1 = new int[,] { { 1, 1, 1, 1, 0 }, { 1, 1, 0, 1, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

        int[,] testGrid2 = new int[,] { { 1, 1, 0, 1, 0 }, { 0, 0, 0, 1, 0 }, { 1, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };


    [TestMethod]
        public void IsThisGridSpaceLand()
        {
            Map testIsland = new Map(testGrid1);

            Assert.IsTrue(testIsland.IsThisSpaceLand(0, 0));
        }

       [TestMethod]
       public void AreAnyNeighborsLandToo()
        {
            Map testIsland = new Map(testGrid1);

            Assert.IsFalse(testIsland.AreAnyNeighborsLand(4, 3));
           
        }
    }
}
