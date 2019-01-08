using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace BuildingBlocks
{
    public abstract class Circular<T,U>: IRotate<T>,IReflect<T>,Reflectable<T>,Rotateable<T>, 
        ITranslate<T>,IBegin,IDirectionDimension, IPointDimension,RetrievableDimension,IDisplay,
        IPeriodic
    {
        protected int numberOfRotations;
        protected CircularLinkedList<U> circularLinkedList;

        protected Point _startingPoint;

        protected int direction;
        protected List<bool> canShootList;
        protected int duration;
        // Letters are made up of directions having each piece equals to divisor.
        protected float divisor; // Each piece making up a direction has this length.
        protected int dimension; // Dimenison.

        public Circular()
        {
            numberOfRotations = 1;
            circularLinkedList = new CircularLinkedList<U>();

            direction = 1;
            canShootList = new List<bool>();
            duration = 1000;
            _startingPoint = new Point();
            dimension = 1;
        }

        public Circular(CircularLinkedList<U> circularLinkedList, int numberOfRotations, int dimension)
        {
            this.numberOfRotations = numberOfRotations ;
            circularLinkedList = new CircularLinkedList<U>();
            direction = 1;
            canShootList = new List<bool>();
            duration = 1000;
            _startingPoint = new Point();
            this.dimension = dimension;
        }
    

        public Circular(CircularLinkedList<U> circularLinkedList, int numberOfRotations,Point startingPoint, int direction,
        float divisor, int duration, int directionDimension)
        {
            this.circularLinkedList = circularLinkedList;
            this.numberOfRotations = numberOfRotations;
            this._startingPoint = startingPoint;
            this.direction = direction;
            this.divisor = divisor;
            this.duration = duration;
            this.dimension = dimension;
        }

        public Circular(Point startingPoint, int direction,
        float divisor, int duration, int directionDimension,int numberOfRotations)
        {
            
            this.numberOfRotations = numberOfRotations;
            this._startingPoint = startingPoint;
            this.direction = direction;
            this.divisor = divisor;
            this.duration = duration;
            circularLinkedList = new CircularLinkedList<U>();
            this.dimension = startingPoint.getDimension();
        }

        public Circular(Point startingPoint, int direction,
        float divisor, List<bool> canShootList,int duration, int directionDimension, int numberOfRotations)
        {

            this.numberOfRotations = numberOfRotations;
            this._startingPoint = startingPoint;
            this.direction = direction;
            this.divisor = divisor;
            this.duration = duration;
            circularLinkedList = new CircularLinkedList<U>();
            this.dimension = startingPoint.getDimension();
            this.canShootList = canShootList;
        }

        public int Direction { get { return direction; } }
        public int Dimension { get { return dimension; } }
        public List<bool> CanShoot { get{ return canShootList; } }
        public int Duration { get { return duration; } }
        public float Divisor { get { return divisor; } }
        public int NumberOfRotations
        {
            set;
            get;
        }

        public Point StartingPoint{get { return _startingPoint; }set { _startingPoint = value; }}


        public abstract void display();
        public abstract int getDimension();
        public abstract int getDuration();
        public abstract Point getStartingPoint();
        public abstract bool isDirectionDimensionCorrect();
        public abstract bool isPointDimensionCorrect();
        public abstract T reflectAboutAxis(int axisIndex);
        public abstract T reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes);
        public abstract T rotateAroundAxis(int indexOfAxis, int numberOfTimes);
        public abstract T rotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes);
        public abstract void setDuration(int timeInMiliiseconds);
        public abstract void setStartingPoint(Point startingPoint);
        public abstract T translate(int coordinateSystemDirection, float amaunt);
    }
}
