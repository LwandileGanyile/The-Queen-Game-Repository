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
    public abstract class NonCircularLetter<T,U>: NonCircular<T,U>,ILetter, IDirectionIterator<U>
    {

        protected SharedDirection sharedDirection;
        protected Plane onPlane;
        protected bool smaller;
        protected char letter;

        protected NonCircularLetter()
        {
            smaller = false;
            letter = 'C';
            sharedDirection = new SharedDirection(10, 1);
        }



        protected NonCircularLetter(Point startingPoint, char letter, int letterDirection,
        Plane onPlane, bool smaller, Dictionary<int, int> duration, int letterDimension)
        :base(startingPoint, letterDirection,
        duration, letterDimension, 1)
        {
            this.onPlane = onPlane;
            this.letter = letter;
            this.smaller = smaller;
            sharedDirection = new SharedDirection(10, 1);
        }

        protected NonCircularLetter(Point startingPoint, char letter, int letterDirection,
        Plane onPlane, bool smaller, Dictionary<int, int> duration, int letterDimension, int numberOfRotations)
        : base(startingPoint, letterDirection,
        duration, letterDimension, numberOfRotations)
        {
            this.onPlane = onPlane;
            this.letter = letter;
            this.smaller = smaller;
            sharedDirection = new SharedDirection(10, 1);
        }

        protected NonCircularLetter(Point _startingPoint, char letter, Plane onPlane, bool smaller, int letterDirection,
        List<bool> canShootList, Dictionary<int, int> duration, int letterDimension, int numberOfRotations)
        :base(_startingPoint, letterDirection,
        canShootList, duration, letterDimension,numberOfRotations)
        {

            this.onPlane = onPlane;
            this.letter = letter;
            this.smaller = smaller;
            sharedDirection = new SharedDirection(10, 1);

        }



        public Plane OnPlane
        {
            get
            {
                return onPlane;
            }

            set
            {

            }
        }

        public bool Smaller
        {
            get
            {
                return smaller;
            }

            set
            {

            }
        }

        public char Letter
        {
            get
            {
                return letter;
            }

            set
            {

            }
        }

        public abstract void DisplayLetterInfo();



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
        
        
        
    }
}
