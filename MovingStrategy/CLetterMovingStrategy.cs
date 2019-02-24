using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularIteration;
using Pieces;

namespace MovingStrategy
{
    public abstract class CLetterMovingStrategy<T,U>: CircularMovingStrategy<T,U>, ILetterIterator<U>
    {

        protected LetterTraceType traceType;

        public LetterTraceType TraceType { get; set; }


        protected CLetterMovingStrategy()
        {

        }

        protected CLetterMovingStrategy(List<T> movingStrategy, LetterTraceType traceType)
        {

        }

        protected CLetterMovingStrategy(List<int> movingStrategy, LetterTraceType traceType)
        {

        }

        protected CLetterMovingStrategy(Point startingPoint, int movingStrategyNumber, LetterTraceType traceType)
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

        public abstract LetterIterator<U> RetrieveLetterIterator();
    }
}
