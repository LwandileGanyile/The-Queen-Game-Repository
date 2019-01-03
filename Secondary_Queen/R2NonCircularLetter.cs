using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;

namespace Secondary_Queen
{
    public class R2NonCircularLetter:NonCircularLetter<R2NonCircularLetter>
    {
        public R2NonCircularLetter()
        {

        }

        public R2NonCircularLetter(R2Point startingPoint, char letter, int letterDirection, bool smaller, int letterDuration)
        {

        }

        public override int CompareTo(R2NonCircularLetter other)
        {
            throw new NotImplementedException();
        }

        public override void display()
        {
            throw new NotImplementedException();
        }

        public override void displayLetterInfo()
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

        public override int getDuration()
        {
            throw new NotImplementedException();
        }

        public override Plane getOnPlane()
        {
            throw new NotImplementedException();
        }

        public override bool getSmaller()
        {
            throw new NotImplementedException();
        }

        public override Point getStartingPoint()
        {
            throw new NotImplementedException();
        }

        public override bool isC(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool isDirectionDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override bool isI(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool isL(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool isM(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool isN(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool isO(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool isPointDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override bool isR(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool isS(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool isW(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter reflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter rotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter rotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override void setDuration(int timeInMiliiseconds)
        {
            throw new NotImplementedException();
        }

        public override void setLetterDirection(int letterDirection)
        {
            throw new NotImplementedException();
        }

        public override void setStartingPoint(Point startingPoint)
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
}
