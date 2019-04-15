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


        public CLetterMovingStrategy()
        :base()
        {
            traceType = LetterTraceType.Direction_Trace;
            Fill();
        }

        protected CLetterMovingStrategy(Point _startingPoint, int direction,
        Dictionary<int, int> duration, int dimension, int numberOfRotations, LetterTraceType traceType)
        :base(_startingPoint, direction, duration, dimension, numberOfRotations)
        {
            this.traceType = traceType;
            Fill();
        }

        protected CLetterMovingStrategy(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int, int> duration, int directionDimension,
        int numberOfRotations, LetterTraceType traceType)
        : base(_startingPoint, direction,
        canShootList, duration, directionDimension, numberOfRotations)
        {
            this.traceType = traceType;
            Fill();
        }

        protected CLetterMovingStrategy(List<U> movingStrategy, LetterTraceType traceType)
        {
            this.traceType = traceType;

            for (int i = 0; i < movingStrategy.Count; i++)
                circularLinkedList.Add(movingStrategy[i]);
            initializeAttributes();
        }

        public abstract LetterIterator<U> RetrieveLetterIterator();
    }
}
