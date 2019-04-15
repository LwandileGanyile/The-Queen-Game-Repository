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
        :base()
        {
            traceType = ShapeTraceType.Direction_Trace;
            Fill();
        }

        protected CShapeMovingStrategy(Point _startingPoint, int direction,
        Dictionary<int, int> duration, int dimension, int numberOfRotations, ShapeTraceType traceType)
        :base(_startingPoint, direction, duration, dimension, numberOfRotations)
        {
            this.traceType = traceType;
            Fill();
        }

        protected CShapeMovingStrategy(Point _startingPoint, int direction,
        List<bool> canShootList, Dictionary<int, int> duration, int directionDimension, 
        int numberOfRotations, ShapeTraceType traceType)
        : base(_startingPoint, direction,
        canShootList, duration, directionDimension, numberOfRotations)
        {
            this.traceType = traceType;
            Fill();
        }

        protected CShapeMovingStrategy(List<U> movingStrategy, ShapeTraceType traceType)
        {
            this.traceType = traceType;

            for (int i = 0; i < movingStrategy.Count; i++)
                circularLinkedList.Add(movingStrategy[i]);
            initializeAttributes();
        }

        public abstract DirectionIterator<U> RetrieveDirectionIterator();
    }
}
