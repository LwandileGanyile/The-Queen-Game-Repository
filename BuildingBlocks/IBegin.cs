﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace BuildingBlocks
{
    public interface IBegin
    {
        void SetStartingPoint(Point startingPoint);
        Point GetStartingPoint();
    }
}
