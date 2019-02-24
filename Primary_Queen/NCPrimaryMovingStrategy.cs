using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovingStrategy;
using NonCircularIteration;

namespace Primary_Queen
{
    public class NCPrimaryMovingStrategy : NCShapeMovingStrategy<R1NonCircularDirection, R1NonCircularDirection>, IPrimaryMovingStrategy
    {


        public NCPrimaryMovingStrategy()
        {

        }

        public NCPrimaryMovingStrategy(List<R1NonCircularDirection> movingStrategy, ShapeTraceType shapeOfTrace)
        {

        }

        public NCPrimaryMovingStrategy(List<int> movingStrategy, ShapeTraceType shapeOfTrace)
        {

        }

        public NCPrimaryMovingStrategy(R1Point startingPoint, int movingStrategyNumber, ShapeTraceType shapeOfTrace)
        {

        }

        public override int CompareTo(R1NonCircularDirection comparableInstance)
        {
            throw new NotImplementedException();
        }

        public override R1NonCircularDirection ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override DirectionIterator<R1NonCircularDirection> RetrieveDirectionIterator()
        {
            throw new NotImplementedException();
        }
    }
}
