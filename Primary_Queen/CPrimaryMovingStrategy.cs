using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovingStrategy;
using CircularIteration;

namespace Primary_Queen
{
    public class CPrimaryMovingStrategy : CircularMovingStrategy<CPrimaryMovingStrategy, R1CircularDirection>, IDirectionIterator<R1CircularDirection>, IPrimaryMovingStrategy
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

        // Compare this moving strategy with the given one.
        // Work the same as the CompareTo method in the NCPrimaryMovingStrategy.
        public override int CompareTo(CPrimaryMovingStrategy comparableInstance)
        {
            throw new NotImplementedException();
        }

        // Work the same as the Display method in the NCPrimaryMovingStrategy.
        // Display string representation for this moving strategy.
        public override void Display()
        {
            throw new NotImplementedException();
        }

        /* Checks whether or not directions making up  this moving strategy have a correct dimension.*/
        // Work the same as the IsDirectionDimensionCorrect method in the NCPrimaryMovingStrategy.
        public override bool IsDirectionDimensionCorrect()
        {
            throw new NotImplementedException();
        }


        /* Checks whether or not points making up  directions  that make up this
        moving strategy have a correct dimension.*/
        // Work the same as the IsPointDimensionCorrect method in the NCPrimaryMovingStrategy.
        public override bool IsPointDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        // Reflect about any axis.
        // Work the same as the ReflectAboutAxis method in the NCPrimaryMovingStrategy.
        public override CPrimaryMovingStrategy ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        // Reflect about any direction that is between two perpendicular axis.
        // Work the same as the ReflectAroundEqualAxis method in the NCPrimaryMovingStrategy.
        public override CPrimaryMovingStrategy ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        // Reflect around any direction that is between two perpendicular axis.
        // Work the same as the ReflectAroundEqualAxis method in the NCPrimaryMovingStrategy.
        public override CPrimaryMovingStrategy ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }


        // Retrieve the direction iterator for this moving stategy.
        // Work the same as the RetrieveDirectionIterator method in the NCPrimaryMovingStrategy.
        public DirectionIterator<R1CircularDirection> RetrieveDirectionIterator()
        {
            throw new NotImplementedException();
        }

        // Rotate around either x-axis, y-axis or z-axis.
        // Work the same as the RotateAroundAxis method in the NCPrimaryMovingStrategy.
        public override CPrimaryMovingStrategy RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        // Rotate the moving strategy. This i haven't yet thought about it.
        // Work the same as the RotateAroundEqualAxis method in the NCPrimaryMovingStrategy.
        public override CPrimaryMovingStrategy RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        // Move this moving strategy by a certain amount.
        // Work the same as the translate method in the NCPrimaryMovingStrategy.
        public override CPrimaryMovingStrategy translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
}
