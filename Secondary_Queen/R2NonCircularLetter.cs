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
            onPlane = R2Plane.GetR2Plane();

            letter = 'C';
            direction = 8;

            _startingPoint = new R2Point().Position;
            smaller = true;
            duration = new Dictionary<int, int>();
            canShootList = new List<bool>();
            numberOfRepeatations = 1;


            AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
            AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);
            AddDirection(new R2Point(), 8, 10, 1, canShootList, duration, numberOfRepeatations);

        }

        public R2NonCircularLetter(R2Point startingPoint, char letter, int letterDirection, bool smaller, Dictionary<int, int> duration)
        :base(startingPoint.Position,letter,letterDirection,R2Plane.GetR2Plane(),smaller,duration,2)
        {
            switch (letter)
            {
                case 'C':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);


                    break;
                case 'L':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);

                    break;
                case 'M':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);


                    break;
                case 'N':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);



                    break;
                case 'O':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);

                    break;
                case 'R':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);



                    break;
                case 'S':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);



                    break;
                case 'W':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, 10, 1, canShootList, duration, numberOfRepeatations);

                    break;

            }
            AddDirection(new R2Point(), letterDirection, 10, 1, canShootList, duration, numberOfRepeatations);
        }

        public R2NonCircularLetter(R2Point startingPoint, char letter,
        int letterDirection, bool smaller, Dictionary<int, int> duration,
        int numberOfRotations)
        : base(startingPoint.Position, letter, letterDirection, R2Plane.GetR2Plane(), 
          smaller, duration, 2, numberOfRotations)
        {
            switch (letter)
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

        protected R2NonCircularLetter(Point _startingPoint, char letter, Plane onPlane, bool smaller, int letterDirection,
        List<bool> canShootList, Dictionary<int, int> duration, int letterDimension, int numberOfRotations)
        :base(_startingPoint, letter, onPlane, smaller, letterDirection,
        canShootList, duration, letterDimension, numberOfRotations)
        {
            switch (letter)
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

        public R2NonCircularLetter(SharedDirection shareDirection)
        {
            onPlane = R2Plane.GetR2Plane();

            letter = 'C';
            direction = 8;

            _startingPoint = new R2Point().Position;
            smaller = true;
            duration = new Dictionary<int, int>();
            canShootList = new List<bool>();
            numberOfRepeatations = 1;


            AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
            AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
            AddDirection(new R2Point(), 8, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);

        }

        public R2NonCircularLetter(R2Point startingPoint, char letter, int letterDirection, bool smaller, Dictionary<int, int> duration,
        SharedDirection shareDirection): base(startingPoint.Position, letter, letterDirection, R2Plane.GetR2Plane(), smaller, duration, 2)
        {
            switch (letter)
            {
                case 'C':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);


                    break;
                case 'L':

                    AddDirection(new R2Point(), 1, 10, 1, canShootList, duration, numberOfRepeatations);

                    break;
                case 'M':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);


                    break;
                case 'N':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);



                    break;
                case 'O':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);

                    break;
                case 'R':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);



                    break;
                case 'S':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);



                    break;
                case 'W':

                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 1, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
                    AddDirection(new R2Point(), 2, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);

                    break;

            }
            AddDirection(new R2Point(), letterDirection, shareDirection.DirectionLength, shareDirection.Divisor, canShootList, duration, numberOfRepeatations);
        }

        public R2NonCircularLetter(R2Point startingPoint, char letter,
        int letterDirection, bool smaller, Dictionary<int, int> duration,
        int numberOfRotations, SharedDirection shareDirection)
        : base(startingPoint.Position, letter, letterDirection, R2Plane.GetR2Plane(),
          smaller, duration, 2, numberOfRotations)
        {
            switch (letter)
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

        protected R2NonCircularLetter(Point _startingPoint, char letter, Plane onPlane, bool smaller, int letterDirection,
        List<bool> canShootList, Dictionary<int, int> duration, int letterDimension, int numberOfRotations, SharedDirection shareDirection)
        : base(_startingPoint, letter, onPlane, smaller, letterDirection,
        canShootList, duration, letterDimension, numberOfRotations)
        {
            switch (letter)
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

        public override R2NonCircularLetter ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
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

        public override R2NonCircularLetter translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }

        private void AddDirection(R2Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShoot, Dictionary<int, int> duration)
        {

            doubleLinkedList.Add(new R2NonCircularDirection(startingPoint, direction, directionLength, directionDivisor, canShoot, duration));
        }

        private void AddDirection(R2Point startingPoint, int direction, float directionLength,
        float directionDivisor, Dictionary<int, int> duration)
        {

            doubleLinkedList.Add(new R2NonCircularDirection(startingPoint, direction, directionLength, directionDivisor, duration));
        }

        private void AddDirection(R2Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int, int> duration, int numberOfRotations)

        {
            doubleLinkedList.Add(new R2NonCircularDirection(startingPoint, direction, directionLength, divisor, duration, numberOfRotations));
        }

        private void AddDirection(R2Point startingPoint, int direction, float directionLength,
        float directionDivisor, List<bool> canShootList, Dictionary<int, int> duration, int numberOfRotations)

        {
            doubleLinkedList.Add(new R2NonCircularDirection(startingPoint, direction, directionLength, directionDivisor, canShootList, duration, numberOfRotations));
        }
    }
}
