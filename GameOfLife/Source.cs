﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Linq;
namespace GameOfLife
{
    class Source<T> : BaseCell where T :BaseCell, new()
    {
        public override Color GetColor()
        {
            return new T().GetColor();
        }
     
        public override void StepForward(int x, int y, BaseCell[,] grid, BaseCell[,] nextGrid)
        {

            if (grid[x, y + 1] == null || grid[x, y + 1] is OffCell)
            {
                nextGrid[x, y + 1] = new T();
            }
        }
    }
}
 