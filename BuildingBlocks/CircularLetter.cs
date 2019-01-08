using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace BuildingBlocks
{
    public abstract class CircularLetter<T,U> : Circular<T,U>, Comparable<T>, ILetterDimension, ILetter
    {

        protected CircularLetter()
        {

        }



        protected CircularLetter(Point startingPoint, char letter, int letterDirection,
        Plane onPlane, bool smaller, int letterDuration, int letterDimension)
        {

        }

        public abstract int compareTo(T comparableInstance);

        public abstract void displayLetterInfo();
        public abstract int getDirection();
        public abstract Plane getOnPlane();
        public abstract bool getSmaller();
        public abstract bool isC(List<int> directions);
        public abstract bool isI(List<int> directions);
        public abstract bool isL(List<int> directions);      
        public abstract bool isLetterDimensionCorrect();
        public abstract bool isM(List<int> directions);
        public abstract bool isN(List<int> directions);
        public abstract bool isO(List<int> directions);
        public abstract bool isR(List<int> directions);
        public abstract bool isS(List<int> directions);
        public abstract bool isW(List<int> directions);
        public abstract void setLetterDirection(int letterDirection);

        Plane ILetter.getOnPlane()
        {
            throw new NotImplementedException();
        }
    }
}
