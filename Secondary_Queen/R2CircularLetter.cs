using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;
using CircularIteration;

namespace Secondary_Queen
{
    public class R2CircularLetter:CircularLetter<R2CircularLetter,R2CircularDirection>, IPointIterator<R2Point>
    {
        public R2CircularLetter()
        {
            onPlane = R2Plane.GetR2Plane();

            letter = 'C';
            direction = 8;
            
            _startingPoint = new R2Point().Position;
            smaller = true;
            duration = new Dictionary<int, int>();
            canShootList = new List<bool>();
            numberOfRotations = 1;


            AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
            AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);
            AddDirection(new R2Point(), 8, 10, 1, canShootList, duration, numberOfRotations);

        }

        public R2CircularLetter(R2Point startingPoint,char letter,int letterDirection,bool smaller,Dictionary<int,int> duration)
        :base(startingPoint.Position,letter,letterDirection,R2Plane.GetR2Plane(),smaller,duration,2)
        {
            switch (Letter)
            {
                case 'C':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);


                    break;
                case 'L':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'M':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);


                    break;
                case 'N':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'O':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'R':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'S':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'W':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);

                    break;

            }
            AddDirection(new R2Point(), letterDirection, 10, 1, canShootList, duration, numberOfRotations);
        }

        public R2CircularLetter(R2Point startingPoint, char letter, 
        int letterDirection, bool smaller, Dictionary<int, int> duration, 
        int numberOfRotations)
        : base(startingPoint.Position, letter, letterDirection, R2Plane.GetR2Plane(), 
          smaller, duration, 2, numberOfRotations)
        {
            switch (Letter)
            {
                case 'C':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);
                    

                    break;
                case 'L':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'M':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);


                    break;
                case 'N':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'O':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'R':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'S':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'W':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);

                    break;

            }
            AddDirection(new R2Point(), letterDirection, 10, 1, canShootList, duration, numberOfRotations);
        }

        protected R2CircularLetter(Point _startingPoint, char letter, Plane onPlane, bool smaller, int letterDirection,
        List<bool> canShootList, Dictionary<int, int> duration, int letterDimension, int numberOfRotations)
        :base(_startingPoint, letter, onPlane, smaller, letterDirection,
        canShootList, duration, letterDimension, numberOfRotations)
        {
            switch (Letter)
            {
                case 'C':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);


                    break;
                case 'L':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'M':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);


                    break;
                case 'N':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'O':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'R':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'S':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);



                    break;
                case 'W':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRotations);

                    break;

            }
            AddDirection(new R2Point(), letterDirection, 10, 1, canShootList, duration, numberOfRotations);
        }

        public R2CircularLetter(SharedDirection shareDirection)
        {
            onPlane = R2Plane.GetR2Plane();

            letter = 'C';
            direction = 8;

            _startingPoint = new R2Point().Position;
            smaller = true;
            duration = new Dictionary<int, int>();
            canShootList = new List<bool>();
            numberOfRotations = 1;
            

            AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
            AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
            AddDirection(new R2Point(), 8, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);

        }

        public R2CircularLetter(R2Point startingPoint, char letter, int letterDirection, bool smaller, Dictionary<int, int> duration,
        SharedDirection shareDirection): base(startingPoint.Position, letter, letterDirection, R2Plane.GetR2Plane(), smaller, duration, 2)
        {
            switch (Letter)
            {
                case 'C':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);


                    break;
                case 'L':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'M':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);


                    break;
                case 'N':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'O':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);

                    break;
                case 'R':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'S':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'W':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);

                    break;

            }
            AddDirection(new R2Point(), letterDirection, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
        }

        public R2CircularLetter(R2Point startingPoint, char letter,
        int letterDirection, bool smaller, Dictionary<int, int> duration,
        int numberOfRotations, SharedDirection shareDirection)
        : base(startingPoint.Position, letter, letterDirection, R2Plane.GetR2Plane(),
          smaller, duration, 2, numberOfRotations)
        {
            switch (Letter)
            {
                case 'C':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);


                    break;
                case 'L':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'M':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);


                    break;
                case 'N':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'O':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);

                    break;
                case 'R':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'S':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'W':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);

                    break;

            }
            AddDirection(new R2Point(), letterDirection, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
        }

        protected R2CircularLetter(Point _startingPoint, char letter, Plane onPlane, bool smaller, int letterDirection,
        List<bool> canShootList, Dictionary<int, int> duration, int letterDimension, int numberOfRotations, SharedDirection shareDirection)
        : base(_startingPoint, letter, onPlane, smaller, letterDirection,
        canShootList, duration, letterDimension, numberOfRotations)
        {
            switch (Letter)
            {
                case 'C':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);


                    break;
                case 'L':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRotations);

                    break;
                case 'M':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);


                    break;
                case 'N':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'O':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);

                    break;
                case 'R':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'S':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);



                    break;
                case 'W':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);

                    break;

            }
            AddDirection(new R2Point(), letterDirection, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRotations);
        }

        public override int CompareTo(R2CircularLetter comparableInstance)
        {
            int returnValue = 0;

            if (letter < comparableInstance.Letter)
            {
                returnValue = -1;
            }

            else if (letter > comparableInstance.Letter)
            {
                returnValue = 1;
            }

            return returnValue;
        }

        public override void Display()
        {
            Console.Write("(-----");

            for (int i = 0; i < circularLinkedList.Size-1; i++)
                Console.WriteLine(circularLinkedList.GetAt(i)+",");
            Console.WriteLine(circularLinkedList.GetAt(circularLinkedList.Size-1) +"----)");
        }

        public override void DisplayLetterInfo()
        {

            int time = 0;

            Console.WriteLine("Letter : "+Letter);
            Console.WriteLine("Letter Direction : "+Direction);
            Console.WriteLine("Smaller : " + Smaller);

            foreach(KeyValuePair<int,int> pair in duration)
            {
                time += pair.Key;
            }


            Console.WriteLine("Letter Duration : "+ time+" milliseconds.");
        }

        private void CreateC()
        {
            
        }

        private void CreateI()
        {

        }

        private void CreateL()
        {

        }

        private void CreateM()
        {

        }

        private void CreateN()
        {

        }

        private void CreateO()
        {

        }

        private void CreateR()
        {

        }

        private void CreateS()
        {

        }

        private void CreateW()
        {

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

        public override DirectionIterator<R2CircularDirection> RetrieveDirectionIterator()
        {
            return new DirectionIterator<R2CircularDirection>(0, circularLinkedList);
        }


        public PointIterator<R2Point> RetrievePointIterator()
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

        public override R2CircularLetter translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }

        private void AddDirection()
        {
            circularLinkedList.Add(new R2CircularDirection());
        }

        private void AddDirection(int direction, R2Point startingPoint, float directionSize,
        float directionDivisor, List<bool> canShoot, Dictionary<int,int> duration)
        {
            
             circularLinkedList.Add(new R2CircularDirection(startingPoint,direction, directionSize, directionDivisor, canShoot, duration));
        }

        private void AddDirection(int direction, R2Point startingPoint, float directionSize, 
        float directionDivisor, Dictionary<int, int> duration)
        {

            circularLinkedList.Add(new R2CircularDirection(startingPoint, direction, directionSize, directionDivisor, duration));
        }

        private void AddDirection(R2Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int, int> duration, int numberOfRotations)

        {
            circularLinkedList.Add(new R2CircularDirection(startingPoint, direction, directionLength, divisor, duration, numberOfRotations));
        }

        private void AddDirection(R2Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShootList, Dictionary<int, int> duration, int numberOfRotations)
        
        {
            circularLinkedList.Add(new R2CircularDirection(startingPoint,direction,directionLength,directionDivisor,canShootList,duration,numberOfRotations));
        }

        public override R2CircularLetter ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }
    }

}
