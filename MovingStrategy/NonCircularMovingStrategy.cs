using System;
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
        {

        }

        protected NonCircularMovingStrategy(List<T> movingStrategy)
        {

        }

        protected NonCircularMovingStrategy(Point startingPoint, int movingStrategyNumber)
        {

        }

       
        
    }
}
