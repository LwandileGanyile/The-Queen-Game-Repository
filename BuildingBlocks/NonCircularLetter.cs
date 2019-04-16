using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;
using SharedResources;
using NonCircularIteration;
using Game_Defination;

namespace BuildingBlocks
{
    public abstract class NonCircularLetter<T,U>: NonCircular<T,U>,ILetter, ILetterDimension, IDirectionIterator<U>
    {

        protected SharedLetter letter;

        protected SharedLetter MyLetter { get; set;}

        // I doubt this constructor.
        protected NonCircularLetter()
        {
            letter = default(SharedLetter);
        }

        protected NonCircularLetter(SharedLetter letter)
        {
            this.letter = letter;
        }

        public void DisplayLetterInfo()
        {
            Console.Write("Type of letter : NonCircularLetter ");
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
