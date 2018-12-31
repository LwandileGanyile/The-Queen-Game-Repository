using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace BuildingBlocks
{
    public abstract class Circular<T>: IRotate<T>,IReflect<T>,Reflectable<T>,Rotateable<T>, 
        ITranslate<T>,IBegin,IDirectionDimension, IPointDimension,RetrievableDimension,IDisplay,
        IPeriodic
    {
        protected int numberOfRotations;
        protected CircularLinkedList<T> circularLinkedList;

        public Circular()
        {

        }

        public Circular(int numberOfRotations)
        {

        }

        public int NumberOfRotations
        {
            set;
            get;
        }

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
