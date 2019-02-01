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
    public abstract class Circular<T,U>: Parent,IRotate<T>,IReflect<T>,IReflectable<T>,IRotateable<T>, 
        ITranslate<T>,IDirectionDimension, IPointDimension,IDisplay
        
    {
        protected int numberOfRotations;
        protected CircularLinkedList<U> circularLinkedList;


        protected Circular()
        :base(){
            numberOfRotations = 1;
            circularLinkedList = new CircularLinkedList<U>();

        }

        protected Circular(Point _startingPoint, int direction,
        float divisor, Dictionary<int,int> duration, int directionDimension,int numberOfRotations)
        :base(_startingPoint,direction,
        divisor,duration,directionDimension,numberOfRotations)
        {
            
            this.numberOfRotations = numberOfRotations;
            circularLinkedList = new CircularLinkedList<U>();
        }

        protected Circular(Point _startingPoint, int direction,
        float divisor, List<bool> canShootList,Dictionary<int,int> duration, int directionDimension, int numberOfRotations)
        :base(_startingPoint,direction,
        divisor,canShootList, duration, directionDimension, numberOfRotations)
        {

            this.numberOfRotations = numberOfRotations;
            circularLinkedList = new CircularLinkedList<U>();
      
        }

        protected void FillCanShootList()
        {
            for (int i = 0; i < circularLinkedList.Size; i++)
                canShootList.Add(false);
        }
       
        public int NumberOfRotations
        {
            set;
            get;
        }

        public abstract void Display();

        public abstract bool IsDirectionDimensionCorrect();
        public abstract bool IsPointDimensionCorrect();

        public override void Clear()
        {
            circularLinkedList.Clear();
        }

        public abstract T ReflectAboutAxis(int axisIndex);
        public abstract T ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes);
        public abstract T RotateAroundAxis(int indexOfAxis, int numberOfTimes);
        public abstract T RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes);
        public abstract T translate(int coordinateSystemDirection, float amaunt);
   
        
    }
}
