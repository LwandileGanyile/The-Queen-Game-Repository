using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularIteration;
using MovingStrategy;

namespace Secondary_Queen
{
    public class R2NonCircularShapeMovingStrategy : CShapeMovingStrategy<R2CircularDirection, R2CircularDirection>
    {
        public R2NonCircularShapeMovingStrategy()
        {

        }

        public R2NonCircularShapeMovingStrategy(R2Point startingPoint, int movingStrategyNumber, ShapeTraceType traceType)
        {

        }

        public R2NonCircularShapeMovingStrategy(List<R2CircularDirection> movingStrategy, ShapeTraceType traceType)
        {

        }

        public R2NonCircularShapeMovingStrategy(List<int> movingStrategy, ShapeTraceType traceType)
        {

        }

        public override DirectionIterator<R2CircularDirection> RetrieveDirectionIterator()
        {
            throw new NotImplementedException();
        }

        public override int CompareTo(R2CircularDirection comparableInstance)
        {
            throw new NotImplementedException();
        }

        public override R2CircularDirection ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }
    }
}
