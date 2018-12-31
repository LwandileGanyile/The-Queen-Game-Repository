using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace BuildingBlocks
{
    public abstract class NonCircularDirection<T>: NonCircular<T>, IDirection,FillableDirection
    {
       

        protected NonCircularDirection()
        {

        }

        

        protected NonCircularDirection(Point startingPoint, int direction, float directionLength,
        float directionDivisor, int directionDuration, int directionDimension)
        {

        }

       

        public abstract void fillDirection();
        public abstract int getDirection();
        public abstract float getDirectionDivisor();
        public abstract float getDirectionLength();
        public abstract bool isDirectionValid(int direction);
        public abstract void setCanShootList(List<bool> canShootList);
        public abstract void setDirectionDivisor(float directionDivisor);
        public abstract void setDirectionLength(float directionLength);
    }
}
