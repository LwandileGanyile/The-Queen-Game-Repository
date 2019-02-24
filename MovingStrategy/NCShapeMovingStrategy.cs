using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NonCircularIteration;
using Pieces;

namespace MovingStrategy
{
    public abstract class NCShapeMovingStrategy<T, U> : NonCircularMovingStrategy<T, U>, IDirectionIterator<U>
    {
        private ShapeTraceType traceType;

        public NCShapeMovingStrategy()
        {

        }

        public NCShapeMovingStrategy(List<T> movingStrategy, ShapeTraceType traceType )
        {

        }

        public NCShapeMovingStrategy(List<int> directions, ShapeTraceType traceType)
        {

        }

        public NCShapeMovingStrategy(Point startingPoint,int movingStrategyNumber, ShapeTraceType traceType)
        {

        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public void Fill()
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

        public override T ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override T ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public abstract DirectionIterator<U> RetrieveDirectionIterator();

        public override T RotateAroundAxis(int indexOfAxis, int numberOfTimes)
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

        
    }

   

   


    

    
}
