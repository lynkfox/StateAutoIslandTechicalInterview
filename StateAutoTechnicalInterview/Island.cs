using System;
using System.Collections.Generic;

namespace StateAutoTechnicalInterview
{
    public class Map
    {
        private int[,] Grid;

        public Map(int[,] testGrid1)
        {
            this.Grid = testGrid1;
        }


        public bool IsThisSpaceLand(int x, int y)
        {

            return Grid[y, x] == 1;
        }

        public bool AreAnyNeighborsLand(int x, int y)
        {
            bool hasLandNeighbors = false;
            
            if(NotOutOfBounds(x,y+1)) //North
            {
                if(IsThisSpaceLand(x, y+1))
                {
                    hasLandNeighbors = true;
                }
            }
            if (NotOutOfBounds(x+1, y)) //East
            {
                if (IsThisSpaceLand(x+1, y))
                {
                    hasLandNeighbors = true;
                }
            }
            if (NotOutOfBounds(x, y - 1)) //South
            {
                if (IsThisSpaceLand(x, y - 1))
                {
                    hasLandNeighbors = true;
                }
            }
            if (NotOutOfBounds(x-1, y)) //West
            {
                if (IsThisSpaceLand(x-1, y))
                {
                    hasLandNeighbors = true;
                }
            }

            return hasLandNeighbors;
        }

        private bool NotOutOfBounds(int x, int y)
        {
            return ((x >= 0 && x <= 4) && (y >= 0 && y <= 3));
         }

        public List<int[,]> DefineIslandStartingAt(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}


