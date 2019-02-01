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
        Plane onPlane, bool smaller, Dictionary<int,int> duration, int letterDimension)
        {

        }

        public abstract int CompareTo(T comparableInstance);

        public abstract void DisplayLetterInfo();
        public abstract int GetDirection();
        public abstract Plane GetOnPlane();
        public abstract bool GetSmaller();
        public abstract bool IsC(List<int> directions);
        public abstract bool IsI(List<int> directions);
        public abstract bool IsL(List<int> directions);      
        public abstract bool IsLetterDimensionCorrect();
        public abstract bool IsM(List<int> directions);
        public abstract bool IsN(List<int> directions);
        public abstract bool IsO(List<int> directions);
        public abstract bool IsR(List<int> directions);
        public abstract bool IsS(List<int> directions);
        public abstract bool IsW(List<int> directions);
        public abstract void GetLetterDirection(int letterDirection);

        

        public abstract void SetLetterDirection(int letterDirection);
    }
}
