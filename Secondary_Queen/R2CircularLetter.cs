using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;

namespace Secondary_Queen
{
    public class R2CircularLetter:CircularLetter<R2CircularLetter,R2CircularDirection>
    {
        public R2CircularLetter()
        {

        }

        public R2CircularLetter(R2Point startingPoint,char letter,int letterDirection,bool smaller,int letterDuration)
        {

        }

        public override int CompareTo(R2CircularLetter comparableInstance)
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

        public override void GetLetterDirection(int letterDirection)
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

        public override bool IsLetterDimensionCorrect()
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

        public override R2CircularLetter ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public override R2CircularLetter ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R2CircularLetter RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public override R2CircularLetter RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        

        public override void SetLetterDirection(int letterDirection)
        {
            throw new NotImplementedException();
        }

       

        public override R2CircularLetter translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
        
}
