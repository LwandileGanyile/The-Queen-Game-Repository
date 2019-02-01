using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;
using SharedResources;
using NonCircularIteration;

namespace BuildingBlocks
{
    public abstract class NonCircularLetter<T,U>: NonCircular<T,U>,ILetter,IComparable<T>, IDirectionIterator<U>
    {
        
        protected NonCircularLetter()
        {

        }

        protected NonCircularLetter(Point startingPoint, char letter, int letterDirection,
        Plane onPlane, bool smaller, Dictionary<int,int> duration, int letterDimension)
        {

        }

        public abstract int CompareTo(T other);

        public abstract void DisplayLetterInfo();
 
        public abstract int GetDirection();
        public abstract Plane GetOnPlane();
        public abstract bool GetSmaller();

        public abstract bool IsC(List<int> directions);
        public abstract bool IsI(List<int> directions);
        public abstract bool IsL(List<int> directions);
        public abstract bool IsM(List<int> directions);
        public abstract bool IsN(List<int> directions);
        public abstract bool IsO(List<int> directions);
        public abstract bool IsR(List<int> directions);
        public abstract bool IsS(List<int> directions);
        public abstract bool IsW(List<int> directions);

        public abstract DirectionIterator<U> RetrieveDirectionIterator();
        
        
        public abstract void SetLetterDirection(int letterDirection);
    }
}
