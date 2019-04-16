using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;
using SharedResources;
using CircularIteration;

namespace BuildingBlocks
{
    public abstract class CircularLetter<T,U> : Circular<T,U>, ILetterDimension, ILetter, IDirectionIterator<U>
    {

        protected SharedLetter letter;

        protected SharedLetter MyLetter { get; set; }

        // I doubt this constructor.
        protected CircularLetter()
        {
            letter = default(SharedLetter);
        }

        protected CircularLetter(SharedLetter letter)
        {
            this.letter = letter;
        }

        public void DisplayLetterInfo()
        {
            Console.Write("Type of letter : CircularLetter ");
            letter.DisplayLetterInfo();
        }

        public bool IsC(List<int> directions)
        {
            return letter.IsC(directions);
        }

        public bool IsI(List<int> directions)
        {
            return letter.IsI(directions);
        }

        public bool IsL(List<int> directions)
        {
            return letter.IsL(directions);
        }

        public abstract bool IsLetterDimensionCorrect();

        public bool IsM(List<int> directions)
        {
            return letter.IsM(directions);
        }

        public bool IsN(List<int> directions)
        {
            return letter.IsN(directions);
        }

        public bool IsO(List<int> directions)
        {
            return letter.IsO(directions);
        }

        public bool IsR(List<int> directions)
        {
            return letter.IsR(directions);
        }

        public bool IsS(List<int> directions)
        {
            return letter.IsS(directions);
        }

        public bool IsW(List<int> directions)
        {
            return letter.IsW(directions);
        }


        public abstract DirectionIterator<U> RetrieveDirectionIterator();
     
    }
}
