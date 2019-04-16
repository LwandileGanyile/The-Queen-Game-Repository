using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace BuildingBlocks
{
    /* The class contains fields and methods that are common in 
     CircularLetter and NonCircularLetter.*/
    public class SharedLetter : ILetter
    {
        private Plane onPlane;
        private bool smaller;
        private char letter;
        private SharedDirection sharedDirection;
        private int letterDirection;
        private Point startingPoint;
        private Dictionary<int, int> duration;


        public SharedLetter(Plane onPlane, Point startingPoint, bool smaller, char letter, SharedDirection sharedDirection, int letterDirection, Dictionary<int, int> duration)
        {
            this.onPlane = onPlane;
            this.smaller = smaller;
            this.letter = letter;
            this.sharedDirection = sharedDirection;
            this.letterDirection = letterDirection;
            this.startingPoint = startingPoint;
            this.duration = duration;
        }

        public int LetterDirection{ get; }
        public Point StartingPoint { get; }

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

        public  void DisplayLetterInfo()
        {
            Console.WriteLine(ToString());
        }


        public override string ToString()
        {
            string letterRepresentation = "";

            letterRepresentation += ("Letter : "+letter+ " letterDirection "+
            letterDirection+"\nLetter divisor : "+ sharedDirection.Divisor+
            "\nSmaller : "+smaller+"Letter direction length : "+sharedDirection.DirectionLength+
            "\nOn Plane : "+
            OnPlane.ToString());

            return letterRepresentation;
        }

        public bool IsC(List<int> directions)
        {


            return (directions.Count == 3 && onPlane.AreDirectionsPerpendicular(directions[0], directions[1]) && directions[0] == directions[2]);
        }

        public bool IsI(List<int> directions)
        {
            return directions.Count == 1 && directions[0] > 0 && directions[0]<=26;
        }

        public bool IsL(List<int> directions)
        {
            return (directions.Count == 2 && onPlane.AreDirectionsPerpendicular(directions[0], directions[1]));
        }

        public bool IsM(List<int> directions)
        {
            return (directions.Count == 4 && 
                onPlane.AreDirectionsOpposite(directions[0],directions[3]) &&
                onPlane.AreDirectionsPerpendicular(directions[1], directions[2]) &&
                onPlane.AreDirectionsNFarApart(directions[0], directions[2],1) &&
                onPlane.AreDirectionsNFarApart(directions[0], directions[1], 3) &&
                onPlane.AreDirectionsNFarApart(directions[1], directions[3], 1));
        }

        public bool IsN(List<int> directions)
        {
            return (directions.Count == 3 &&
                onPlane.AreDirectionsOpposite(directions[0], directions[2]) &&
                onPlane.AreDirectionsNFarApart(directions[0], directions[1], 3) &&
                onPlane.AreDirectionsNFarApart(directions[2], directions[3], 1));
        }

        public bool IsO(List<int> directions)
        {
            return (directions.Count == 4 &&
                onPlane.AreDirectionsOpposite(directions[0], directions[2]) &&
                onPlane.AreDirectionsOpposite(directions[1], directions[3]) &&

                onPlane.AreDirectionsPerpendicular(directions[0], directions[1]) &&
                onPlane.AreDirectionsPerpendicular(directions[0], directions[3]) &&

                onPlane.AreDirectionsPerpendicular(directions[1], directions[2])

                );
        }

        public bool IsR(List<int> directions)
        {
            return (directions.Count == 4 &&
                onPlane.AreDirectionsPerpendicular(directions[0], directions[1]) &&
                onPlane.AreDirectionsNFarApart(directions[0], directions[2],5) &&
                onPlane.AreDirectionsNFarApart(directions[0], directions[3], 3) &&

                onPlane.AreDirectionsNFarApart(directions[1], directions[2],3) &&
                onPlane.AreDirectionsNFarApart(directions[1], directions[3], 1) &&

                onPlane.AreDirectionsPerpendicular(directions[2], directions[3]) 

                );
        }

        public bool IsS(List<int> directions)
        {
            return (directions.Count == 5 &&
                onPlane.AreDirectionsOpposite(directions[0], directions[2]) &&
                directions[0]==directions[4] &&
                onPlane.AreDirectionsPerpendicular(directions[0], directions[1]) &&
                onPlane.AreDirectionsPerpendicular(directions[0], directions[3]) &&


                directions[1] == directions[3] &&
                onPlane.AreDirectionsPerpendicular(directions[1], directions[2]) &&
                onPlane.AreDirectionsPerpendicular(directions[1], directions[4]) &&


                onPlane.AreDirectionsPerpendicular(directions[2], directions[3]) &&
                onPlane.AreDirectionsOpposite(directions[2], directions[4]) &&

                 onPlane.AreDirectionsPerpendicular(directions[3], directions[4]) 

                );
        }

        public bool IsW(List<int> directions)
        {
            return (directions.Count == 4 &&

                onPlane.AreDirectionsPerpendicular(directions[0], directions[1]) &&
                directions[0] == directions[2] &&
                onPlane.AreDirectionsPerpendicular(directions[0], directions[1]) &&
                onPlane.AreDirectionsNFarApart(directions[0], directions[3], 2) &&

                onPlane.AreDirectionsPerpendicular(directions[1], directions[2]) &&
                directions[1] == directions[3]);
        }
    }
}
