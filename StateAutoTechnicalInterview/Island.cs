﻿using System;

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
    }
}


