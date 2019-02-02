using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NonCircularIteration;
using Pieces;

namespace MovingStrategy
{
    public abstract class NCLetterMovingStrategy<T,U>:NonCircularMovingStrategy<T,U>, ILetterIterator<U>
    {

        private LetterTraceType traceType;

        public NCLetterMovingStrategy()
        {

        }

        public NCLetterMovingStrategy(List<T> movingStrategy, LetterTraceType traceType)
        {

        }

        public NCLetterMovingStrategy(Point startingPoint, int movingStrategyNumber, LetterTraceType traceType)
        {

        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void Fill()
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

        public abstract LetterIterator<U> RetrieveLetterIterator();

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
