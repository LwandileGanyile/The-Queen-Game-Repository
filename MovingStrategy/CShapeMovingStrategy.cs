using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;
using CircularIteration;

namespace MovingStrategy
{
    public abstract class CShapeMovingStrategy<T, U> : CircularMovingStrategy<T, U>, IDirectionIterator<U>
    {
        protected ShapeTraceType traceType;

        public ShapeTraceType TraceType { get; set; }


        public CShapeMovingStrategy()
        {

        }

        protected CShapeMovingStrategy(List<T> movingStrategy, ShapeTraceType traceType)
        {

        }

        protected CShapeMovingStrategy(List<int> movingStrategy, ShapeTraceType traceType)
        {

        }

        protected CShapeMovingStrategy(Point startingPoint, int movingStrategyNumber, ShapeTraceType traceType)
        {

        }

       
        public void Fill()
        {
            throw new NotImplementedException();
        }

        public override T RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override bool IsPointDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override T ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override bool IsDirectionDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override T ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override T RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override T translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public abstract DirectionIterator<U> RetrieveDirectionIterator();
    }
}
