﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;
using SharedResources;
using NonCircularIteration;

namespace MovingStrategy
{
    public abstract class NonCircularMovingStrategy<T,U>: NonCircular<T,U>, IMovingStrategy
    {
        protected NonCircularMovingStrategy()
        :base(){

        }

        protected NonCircularMovingStrategy(Point _startingPoint, int direction,
        Dictionary<int, int> duration, int directionDimension, int numberOfRepeatations)
        : base(_startingPoint, direction,
        duration, directionDimension, numberOfRepeatations)
        {

        }

        protected NonCircularMovingStrategy(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int, int> duration, int directionDimension, int numberOfRepeatations)
        : base(_startingPoint, direction,
        canShootList, duration, directionDimension, numberOfRepeatations)
        {

        }



    }
}
