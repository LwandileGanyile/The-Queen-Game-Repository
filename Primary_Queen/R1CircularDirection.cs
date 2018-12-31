using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;

namespace Primary_Queen
{
    public class R1CircularDirection : CircularDirection<R1CircularDirection>
    {
        public R1CircularDirection()
        {

        }

        public R1CircularDirection(R1Point startingPoint, int direction, float directionLength, float directionDivisor, List<bool> canShootList, int directionDuration)
        {

        }

        public override void display()
        {
            throw new NotImplementedException();
        }

        public override int getDimension()
        {
            throw new NotImplementedException();
        }

        public override int getDirection()
        {
            throw new NotImplementedException();
        }

        public override float getDirectionDivisor()
        {
            throw new NotImplementedException();
        }

        public override float getDirectionLength()
        {
            throw new NotImplementedException();
        }

        public override int getDuration()
        {
            throw new NotImplementedException();
        }

        public override Point getStartingPoint()
        {
            throw new NotImplementedException();
        }

        public override bool isDirectionDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override bool isDirectionValid(int direction)
        {
            throw new NotImplementedException();
        }

        public override bool isPointDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection reflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection rotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection rotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override void setCanShootList(List<bool> canShootList)
        {
            throw new NotImplementedException();
        }

        public override void setDirectionDivisor(float directionDivisor)
        {
            throw new NotImplementedException();
        }

        public override void setDirectionLength(float directionLength)
        {
            throw new NotImplementedException();
        }

        public override void setDuration(int timeInMiliiseconds)
        {
            throw new NotImplementedException();
        }

        public override void setStartingPoint(Point startingPoint)
        {
            throw new NotImplementedException();
        }

        public override R1CircularDirection translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
}
