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
        :base()
        {
            traceType = LetterTraceType.Direction_Trace;
            Fill();
        }

        protected NCLetterMovingStrategy(Point _startingPoint, int direction,
        Dictionary<int, int> duration, int dimension, int numberOfRepeatations, LetterTraceType traceType)
        :base(_startingPoint, direction, duration, dimension, numberOfRepeatations)
        {
            this.traceType = traceType;
            Fill();
        }

        protected NCLetterMovingStrategy(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int, int> duration, int directionDimension,
        int numberOfRepeatations, LetterTraceType traceType)
        : base(_startingPoint, direction,
        canShootList, duration, directionDimension, numberOfRepeatations)
        {
            this.traceType = traceType;
            Fill();
        }

        protected NCLetterMovingStrategy(List<U> movingStrategy, LetterTraceType traceType)
        {
            this.traceType = traceType;

            for (int i = 0; i < movingStrategy.Count; i++)
                doubleLinkedList.Add(movingStrategy[i]);
            initializeAttributes();
        }

        public abstract LetterIterator<U> RetrieveLetterIterator();
    }

    
}
