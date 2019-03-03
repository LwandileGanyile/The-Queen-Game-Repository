using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;
using SharedResources;
using CircularIteration;

namespace BuildingBlocks
{
    public abstract class CircularDirection<T,U>: Circular<T,U>,IPointIterator<U>, IDirection

    {

        protected SharedDirection sharedDirection;

        
        protected CircularDirection():base()
        {
            sharedDirection = new SharedDirection(10, 1);

        }

        // Construct without specifying the canshoot property.
        protected CircularDirection(Point startingPoint, int direction, float directionLength,
        float divisor,Dictionary<int,int> duration, int directionDimension, int numberOfRotations)
        : base(startingPoint, direction, duration, directionDimension, numberOfRotations)
        {
            sharedDirection = new SharedDirection(directionLength, divisor);
        }

        // Construct without specifying the  length property cause it doesnh't exist.
        protected CircularDirection(Point startingPoint, int direction,
        float directionDivisor, List<bool> canShootList, Dictionary<int,int> duration, int directionDimension)
        : base(startingPoint, direction, canShootList, duration, directionDimension, 1)
        {
            sharedDirection = new SharedDirection(10 * directionDivisor, directionDivisor);
        }

        // Construct without specifying the number of rotations.
        protected CircularDirection(Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShootList,Dictionary<int,int> duration, int directionDimension)
        :base(startingPoint, direction, canShootList,duration,directionDimension,1)
        {
            sharedDirection = new SharedDirection(directionLength, directionDivisor);
        }

        // Construct by specifying the number of rotations.
        protected CircularDirection(Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShootList, Dictionary<int,int> duration, int directionDimension,int numberOfRotations)
        : base(startingPoint, direction, canShootList, duration, directionDimension, numberOfRotations)
        {
            sharedDirection = new SharedDirection(directionLength, directionDivisor);
        }

     
        public SharedDirection SharedDirection
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


        
        
        // Checks whether or not the direction is valid.
        public abstract bool IsDirectionValid(int direction);
        // Update the points in this direction that can shoot.
    
        // Sets the divisor of this direction.
        public void SetDirectionDivisor(float directionDivisor)
        {
            sharedDirection.Divisor = directionDivisor;
            circularLinkedList.Clear();
           

        }
        // Sets the length of this direction.
        public void SetDirectionLength(float directionLength)
        {
            sharedDirection.DirectionLength = directionLength;

            circularLinkedList.Clear();
            
        }

        // Sets the divisor of this direction.
        public float GetDirectionDivisor()
        {
            return sharedDirection.Divisor;

        }
        // Sets the length of this direction.
        public float GetDirectionLength()
        {
            return sharedDirection.DirectionLength;

            
        }

        protected void FillCanShootList()
        {
            for (int i = 0; i < sharedDirection.DirectionLength / sharedDirection.Divisor; i++)
                canShootList.Add(false);
        }

        protected void FillDuration()
        {
            for (int i = 0; i < sharedDirection.DirectionLength/sharedDirection.Divisor; i++)
                duration.Add(i, (int)(1000 / (sharedDirection.DirectionLength / sharedDirection.Divisor)));
        }

        public override string ToString()
        {
            return  sharedDirection.ToString()+ "\n"+base.ToString();
        }


        public abstract PointIterator<U> RetrievePointIterator();
        
    }

}
