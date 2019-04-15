using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;
using SharedResources;
using CircularIteration;

namespace MovingStrategy
{
    public abstract class CircularMovingStrategy<T,U>: Circular<T, U>, IMovingStrategy
    {
        

        protected CircularMovingStrategy()
        :base()
        {
           
        }

        protected CircularMovingStrategy(Point _startingPoint, int direction,
        Dictionary<int, int> duration, int directionDimension, int numberOfRotations)
        : base(_startingPoint, direction,
        duration, directionDimension, numberOfRotations)
        {
            
        }

        protected CircularMovingStrategy(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int, int> duration, int directionDimension, int numberOfRotations)
        : base(_startingPoint, direction,
        canShootList, duration, directionDimension, numberOfRotations)
        {
            
        }



    }
}
