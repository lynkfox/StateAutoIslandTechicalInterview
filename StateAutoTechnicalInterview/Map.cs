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

        public List<int[]> WhichNeighborsAreLand(int x, int y)
        {
            List<int[]> NeighboringLandCoords = new List<int[]>();
            
            if(NotOutOfBounds(x,y+1)) //North
            {
                if(IsThisSpaceLand(x, y+1))
                {
                    NeighboringLandCoords.Add(new int[] { x, y + 1 });
                }
            }
            if (NotOutOfBounds(x+1, y)) //East
            {
                if (IsThisSpaceLand(x+1, y))
                {
                    NeighboringLandCoords.Add(new int[] { x + 1, y });
                }
            }
            if (NotOutOfBounds(x, y - 1)) //South
            {
                if (IsThisSpaceLand(x, y - 1))
                {
                    NeighboringLandCoords.Add(new int[] { x, y - 1 });
                }
            }
            if (NotOutOfBounds(x-1, y)) //West
            {
                if (IsThisSpaceLand(x-1, y))
                {
                    NeighboringLandCoords.Add(new int[] { x - 1, y });
                }
            }

            return NeighboringLandCoords;
        }

        private bool NotOutOfBounds(int x, int y)
        {
            return ((x >= 0 && x <= 4) && (y >= 0 && y <= 3));
        }

        public List<int[]> DefineIslandStartingAt(int x, int y)
        {
            List<int[]> CoordinatesOfIsland = new List<int[]>();
            int TotalLands = 0;

            if (IsThisSpaceLand(x, y))
            {
                CoordinatesOfIsland.Add(new int[] { x, y });

                List<int[]> LandNeighbors = WhichNeighborsAreLand(x, y);

                TotalLands = LandNeighbors.Count;

                if(TotalLands == 0)
                {
                    return CoordinatesOfIsland;
                }
                else
                {
                    
                }

            }

            return CoordinatesOfIsland;
        }

    }
}


