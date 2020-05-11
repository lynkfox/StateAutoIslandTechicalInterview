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

        /*
        11010
        00010
        11000
        00000
        */

        /*
        11110
        11010
        11000
        00000
        */
        [TestMethod]
        public void IsThisGridSpaceLand()
        {
            Island testIsland = new Island();

            Assert.IsTrue(testIsland.IsThisSpaceLand(0, 0));
        }
    }
}
