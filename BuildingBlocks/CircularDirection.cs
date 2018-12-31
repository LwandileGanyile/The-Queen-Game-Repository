using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace BuildingBlocks
{
    public abstract class CircularDirection<T>: Circular<T>,IDirection,FillableDirection
    {
       

        protected CircularDirection()
        {

        }

        

        protected CircularDirection(Point startingPoint, int direction, float directionLength,
        float directionDivisor, int directionDuration, int directionDimension)
        {

        }


        public void fillDirection()
        {
            throw new NotImplementedException();
        }

        public abstract int getDirection();
        public abstract float getDirectionDivisor();
        public abstract float getDirectionLength();
        public abstract bool isDirectionValid(int direction);
        public abstract void setCanShootList(List<bool> canShootList);
        public abstract void setDirectionDivisor(float directionDivisor);
        public abstract void setDirectionLength(float directionLength);
    }

}
