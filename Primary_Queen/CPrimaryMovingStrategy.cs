using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovingStrategy;
using CircularIteration;

namespace Primary_Queen
{
    public class CPrimaryMovingStrategy : CircularMovingStrategy<R1CircularDirection, R1CircularDirection>, IDirectionIterator<R1CircularDirection>, IPrimaryMovingStrategy
    {

        public CPrimaryMovingStrategy()
        {

        }

        public CPrimaryMovingStrategy(List<R1NonCircularDirection> movingStrategy, ShapeTraceType shapeOfTrace)
        {

        }

        public CPrimaryMovingStrategy(List<int> movingStrategy, ShapeTraceType shapeOfTrace)
        {

        }

        public CPrimaryMovingStrategy(R1Point startingPoint, int movingStrategyNumber, ShapeTraceType shapeOfTrace)
        {

        }

        public override int CompareTo(R1CircularDirection comparableInstance)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override bool IsDirectionDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override bool IsPointDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public DirectionIterator<R1CircularDirection> RetrieveDirectionIterator()
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
}
