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
        :base()
        {
            traceType = ShapeTraceType.Direction_Trace;
            Fill();
        }

        protected NCShapeMovingStrategy(Point _startingPoint, int direction,
        Dictionary<int, int> duration, int dimension, int numberOfRepeatation, ShapeTraceType traceType)
        :base(_startingPoint, direction, duration, dimension, numberOfRepeatation)
        {
            this.traceType = traceType;
            Fill();
        }

        protected NCShapeMovingStrategy(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int, int> duration, int directionDimension,
        int numberOfRepeatation, ShapeTraceType traceType)
        : base(_startingPoint, direction,
        canShootList, duration, directionDimension, numberOfRepeatation)
        {
            this.traceType = traceType;
            Fill();
        }

        protected NCShapeMovingStrategy(List<U> movingStrategy, ShapeTraceType traceType)
        {
            this.traceType = traceType;

            for (int i = 0; i < movingStrategy.Count; i++)
                doubleLinkedList.Add(movingStrategy[i]);
            initializeAttributes();
        }

        public abstract DirectionIterator<U> RetrieveDirectionIterator();

    }

   

   


    

    
}
