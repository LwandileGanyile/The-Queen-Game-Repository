using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;
using SharedResources;
using NonCircularIteration;

namespace BuildingBlocks
{
    public abstract class NonCircularDirection<T,U>: NonCircular<T,U>, IPointIterator<U>
    {

        protected SharedDirection sharedDirection;

        protected NonCircularDirection()
        {

            sharedDirection = new SharedDirection(10,1);
        }

        // Construct without specifying the canshootlist property.
        protected NonCircularDirection(Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int,int> duration, int directionDimension, int numberOfRotations)
        : base(startingPoint, direction,duration, directionDimension, numberOfRotations)
        {
            sharedDirection = new SharedDirection(directionLength, divisor);
        }

        // Construct without specifying the  length property cause it doesnh't exist.
        protected NonCircularDirection(Point startingPoint, int direction,
        float directionDivisor, List<bool> canShootList, Dictionary<int,int> duration, int directionDimension)
        : base(startingPoint, direction, canShootList, duration, directionDimension, 1)
        {
            sharedDirection = new SharedDirection(10* directionDivisor, directionDivisor);
        }

        // Construct without specifying the number of rotations.
        protected NonCircularDirection(Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShootList, Dictionary<int,int> duration, int directionDimension)
        : base(startingPoint, direction, canShootList, duration, directionDimension, 1)
        {
            sharedDirection = new SharedDirection(directionLength, directionDivisor);
        }

        // Construct by specifying the number of rotations.
        protected NonCircularDirection(Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShootList, Dictionary<int, int> duration, int directionDimension, int numberOfRotations)
        : base(startingPoint, direction, canShootList, duration, directionDimension, numberOfRotations)
        {
            sharedDirection = new SharedDirection(directionLength, directionDivisor);
        }

        public  SharedDirection SharedDirection
        {
            get
            {
                return sharedDirection;
            }

            set
            {
                if (value != null)
                    sharedDirection = value;
            }
        }

       
        
        public float GetDirectionDivisor() { return SharedDirection.Divisor; }
        // Returns a direction length;
        public float GetDirectionLength() { return SharedDirection.DirectionLength; }
        // Checks whether or not the direction is valid.
        public abstract bool IsDirectionValid(int direction);
        // Update the points in this direction that can shoot.
        public void SetCanShootList(List<bool> canShootList) { this.canShootList = canShootList; }
        
        // Sets the divisor of this direction.
        public void SetDirectionDivisor(float directionDivisor)
        {
            sharedDirection.Divisor = directionDivisor;
            doubleLinkedList.Clear();
           

        }
        // Sets the length of this direction.
        public void SetDirectionLength(float directionLength)
        {
            sharedDirection.DirectionLength = directionLength;

            doubleLinkedList.Clear();
          
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + sharedDirection.ToString();
        }



        public abstract PointIterator<U> RetrievePointIterator();
       


    }
}
