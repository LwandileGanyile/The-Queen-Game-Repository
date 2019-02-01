using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;
using Parents;

namespace BuildingBlocks
{
    public abstract class NonCircular<T,U> :Parent, IRotate<T>, IReflect<T>, IReflectable<T>, IRotateable<T>,
        ITranslate<T>, IDirectionDimension, IPointDimension, IDisplay
    {
        protected int numberOfRepeatations;
        protected DoubleLinkedList<U> doubleLinkedList;

        public NonCircular():base()
        {
            numberOfRepeatations = 1;
            doubleLinkedList = new DoubleLinkedList<U>();
        }

        protected NonCircular(Point _startingPoint, int direction,
        float divisor, Dictionary<int,int> duration, int directionDimension, int numberOfRepeatations)
        :base(_startingPoint, direction,
        divisor, duration,directionDimension, numberOfRepeatations)
        {

            this.numberOfRepeatations = numberOfRepeatations;
            doubleLinkedList = new DoubleLinkedList<U>();
            
        }

        protected NonCircular(Point _startingPoint, int direction,
        float divisor, List<bool> canShootList, Dictionary<int,int> duration, int directionDimension, int numberOfRepeatations)
        :base(_startingPoint, direction,
        divisor, canShootList, duration, directionDimension, numberOfRepeatations)
        {

            this.numberOfRepeatations = numberOfRepeatations;
            
            doubleLinkedList = new DoubleLinkedList<U>();
            
        }

        public int NumberOfRepeatations
        {
            set;
            get;
        }

        protected void FillCanShootList()
        {
            for (int i = 0; i < doubleLinkedList.Size; i++)
                canShootList.Add(false);
        }

        public abstract void Display();

        public abstract bool IsDirectionDimensionCorrect();
        public abstract bool IsPointDimensionCorrect();

        public abstract T ReflectAboutAxis(int axisIndex);
        public abstract T ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes);
        public abstract T RotateAroundAxis(int indexOfAxis, int numberOfTimes);
        public abstract T RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes);


        public abstract T translate(int coordinateSystemDirection, float amaunt);

        public override void Clear()
        {
            doubleLinkedList.Clear();
        }
    }
}
