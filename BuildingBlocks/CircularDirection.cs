using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace BuildingBlocks
{
    public abstract class CircularDirection<T,U>: Circular<T,U>,IDirection,FillableDirection
    {
        
        protected float directionLength;

        protected CircularDirection():base()
        {
           
        }

       
        protected CircularDirection(Point startingPoint, int direction,
        float directionDivisor, List<bool> canShootList,int duration, int directionDimension)
        :base(startingPoint,direction,directionDivisor,canShootList,duration,directionDimension,1)
        {
            
        }

        protected CircularDirection(Point startingPoint, int direction,
       float divisor, int duration, int directionDimension,int numberOfRotations)
        
        : base(startingPoint, direction,divisor, duration, directionDimension,numberOfRotations)
        {
           
        }

        // Fill this direction with correct points/nodes.
        public abstract void fillDirection();

        // Returns a positive integer representing this direction.
        public abstract int getDirection();
        // Returns a direction divisor.
        public abstract float getDirectionDivisor();
        // Returns a direction length;
        public abstract float getDirectionLength();
        // Checks whether or not the direction is valid.
        public abstract bool isDirectionValid(int direction);
        // Update the points in this direction that can shoot.
        public abstract void setCanShootList(List<bool> canShootList);
        // Sets the divisor of this direction.
        public abstract void setDirectionDivisor(float directionDivisor);
        // Sets the length of this direction.
        public abstract void setDirectionLength(float directionLength);
    }

}
