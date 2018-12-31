using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;

namespace Secondary_Queen
{
    public class R2CircularLetter:CircularLetter<R2CircularLetter>
    {
        public R2CircularLetter()
        {

        }

        public R2CircularLetter(R2Point startingPoint,char letter,int letterDirection,bool smaller,int letterDuration)
        {

        }

        public override int compareTo(R2CircularLetter comparableInstance)
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

        public override bool isLetterDimensionCorrect()
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

        public override CircularLetter reflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override CircularLetter reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override CircularLetter rotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override CircularLetter rotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
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

        public override CircularLetter translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
        
}
