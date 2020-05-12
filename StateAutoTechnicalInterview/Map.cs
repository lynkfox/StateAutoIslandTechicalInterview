using System;
using System.Collections.Generic;
using System.Linq;

namespace StateAutoTechnicalInterview
{
    public class Map
    {
        private int[,] Grid;

        public List<int[]> Lands { get; set; } = new List<int[]>();

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

            foreach(int[] coords in AllNeighborCoords(x, y))
            {
                if(IsThisSpaceLand(coords[0], coords[1]))
                {
                    NeighboringLandCoords.Add(coords);
                }
            }

            return NeighboringLandCoords;
        }

        private bool NotOutOfBounds(int x, int y)
        {
            return ((x >= 0 && x <= 4) && (y >= 0 && y <= 3));
        }

        public List<int[]> AllNeighborCoords(int x, int y)
        {
            List<int[]> NeighboringCoords = new List<int[]>();
            if (NotOutOfBounds(x, y + 1)) //North
            {
                NeighboringCoords.Add(new int[] { x, y + 1 });
                
            }
            if (NotOutOfBounds(x + 1, y)) //East
            {
                NeighboringCoords.Add(new int[] { x + 1, y });
                
            }
            if (NotOutOfBounds(x, y - 1)) //South
            {
                NeighboringCoords.Add(new int[] { x, y - 1 });
                
            }
            if (NotOutOfBounds(x - 1, y)) //West
            {
                NeighboringCoords.Add(new int[] { x - 1, y });
                
            }

            return NeighboringCoords;
        }

        public int Search()
        {
            int totalIslands = 0;
            for(int x=0; x < 5; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if(IsThisSpaceLand(x,y))
                    {
                        if(!AlreadyHasCoordsSearched(x,y))
                        {
                            totalIslands++;
                            DiscoverFullIsland(x, y);
                        }
                    }
                }
            }
            return totalIslands;
        }

        public bool AlreadyHasCoordsSearched(int x, int y)
        {

            return Lands.Any(search => search.SequenceEqual(new int[] { x, y }));
        }

        public void DiscoverFullIsland(int x, int y)
        {
            Lands.Add(new int[] { x, y });

            foreach (int[] coords in WhichNeighborsAreLand(x,y))
            {
                if(!AlreadyHasCoordsSearched(coords[0],coords[1]))
                {
                    DiscoverFullIsland(coords[0], coords[1]);
                }
            }
        }
    }
}

        


