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
        {

        }

        protected CircularMovingStrategy(List<T> movingStrategy)
        {

        }

        protected CircularMovingStrategy(Point startingPoint, int movingStrategyNumber)
        {

        }

        
    }
}
