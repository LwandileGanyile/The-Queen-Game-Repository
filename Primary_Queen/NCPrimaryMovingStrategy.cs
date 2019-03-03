using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovingStrategy;
using NonCircularIteration;

namespace Primary_Queen
{
    public class NCPrimaryMovingStrategy : NCShapeMovingStrategy<NCPrimaryMovingStrategy, R1NonCircularDirection>, IDirectionIterator<R1NonCircularDirection>, IPrimaryMovingStrategy
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

        // Compare this moving strategy with the given one.
        // Work the same as the CompareTo method in the NCPrimaryMovingStrategy.
        public override int CompareTo(NCPrimaryMovingStrategy comparableInstance)
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
        public override NCPrimaryMovingStrategy ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        // Reflect about any direction that is between two perpendicular axis.
        // Work the same as the ReflectAroundEqualAxis method in the NCPrimaryMovingStrategy.
        public override NCPrimaryMovingStrategy ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        // Reflect around any direction that is between two perpendicular axis.
        // Work the same as the ReflectAroundEqualAxis method in the CPrimaryMovingStrategy.
        public override NCPrimaryMovingStrategy ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }


        // Retrieve the direction iterator for this moving stategy.
        // Work the same as the RetrieveDirectionIterator method in the CPrimaryMovingStrategy.
        public override DirectionIterator<R1NonCircularDirection> RetrieveDirectionIterator()
        {
            throw new NotImplementedException();
        }

        // Rotate around either x-axis, y-axis or z-axis.
        // Work the same as the RotateAroundAxis method in the CPrimaryMovingStrategy.
        public override NCPrimaryMovingStrategy RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        // Rotate the moving strategy. This i haven't yet thought about it.
        // Work the same as the RotateAroundEqualAxis method in the CPrimaryMovingStrategy.
        public override NCPrimaryMovingStrategy RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        // Move this moving strategy by a certain amount.
        // Work the same as the translate method in the CPrimaryMovingStrategy.
        public override NCPrimaryMovingStrategy translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
}
