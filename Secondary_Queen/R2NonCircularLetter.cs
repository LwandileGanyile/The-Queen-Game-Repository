using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;
using NonCircularIteration;

namespace Secondary_Queen
{
    public class R2NonCircularLetter:NonCircularLetter<R2NonCircularLetter, R2NonCircularDirection>, IPointIterator<R2Point>
    {
        public R2NonCircularLetter()
        {

        }

        public R2NonCircularLetter(R2Point startingPoint, char letter, int letterDirection, bool smaller, Dictionary<int,int> duration)
        {

        }

        public override int CompareTo(R2NonCircularLetter other)
        {
            throw new NotImplementedException();
        }

        public override void Display()
        {
            throw new NotImplementedException();
        }

        public override void DisplayLetterInfo()
        {
            throw new NotImplementedException();
        }

        public override void Fill()
        {
            throw new NotImplementedException();
        }

       
        public override int GetDirection()
        {
            throw new NotImplementedException();
        }

        
        public override Plane GetOnPlane()
        {
            throw new NotImplementedException();
        }

        public override bool GetSmaller()
        {
            throw new NotImplementedException();
        }

        
        public override bool IsC(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool IsDirectionDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override bool IsI(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool IsL(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool IsM(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool IsN(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool IsO(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool IsPointDimensionCorrect()
        {
            throw new NotImplementedException();
        }

        public override bool IsR(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool IsS(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override bool IsW(List<int> directions)
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override DirectionIterator<R2NonCircularDirection> RetrieveDirectionIterator()
        {
            throw new NotImplementedException();
        }

        public override LetterIterator<R2NonCircularLetter> RetrieveLetterIterator()
        {
            throw new NotImplementedException();
        }

        public PointIterator<R2Point> RetrievePointIterator()
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R2NonCircularLetter RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

       

        public override void SetLetterDirection(int letterDirection)
        {
            throw new NotImplementedException();
        }

       

        public override R2NonCircularLetter translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
}
