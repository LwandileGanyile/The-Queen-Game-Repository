using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;
using NonCircularIteration;
using SharedResources;

namespace Primary_Queen
{
    public class R1NonCircularDirection:NonCircularDirection<R1NonCircularDirection,R1Point>, IFill
    {


        public R1NonCircularDirection()
        {
            StartingPoint = new R1Point().Position;
            Fill();
            FillCanShootList();
           
        }
   
        // Construct without specifying the length property.
        public R1NonCircularDirection(R1Point startingPoint, int direction,
        float directionDivisor,Dictionary<int,int> duration)
        : base(startingPoint.Position, direction, directionDivisor, new List<bool>(), duration, 1)
        {
            Fill();
        }

        // Construct without specifying the number of rotations.
        public R1NonCircularDirection(R1Point startingPoint, int direction, float directionLength,
        float directionDivisor, Dictionary<int,int> duration)
        : base(startingPoint.Position, direction, directionLength, directionDivisor, new List<bool>(), duration, 1)
        {
            Fill();
            FillCanShootList();
        }

        // Construct by specifying the number of rotations.
        public R1NonCircularDirection(R1Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int,int> duration, int numberOfRotations)
        : base(startingPoint.Position, direction, directionLength, divisor, new List<bool>(), duration, 1, numberOfRotations)
        {
            Fill();
            FillCanShootList();
        }

        // Displays an R1NonCircularDirection. However the method suppose to be on a super class "CircularDirection".
        public override void Display()
        {
            for (int i = 0; i < doubleLinkedList.Size; i++)
            {
                doubleLinkedList.GetAt(i).Display();
                if (i !=doubleLinkedList.Size - 1)
                    Console.Write(" , ");
            }
        }
      
        public void Fill()
        {
            R1Point point = new R1Point(_startingPoint);
            doubleLinkedList.Add(point);

            // Going left.
            if (Direction == 1)
                for (int i = 1; i <= SharedDirection.DirectionLength / SharedDirection.Divisor; i++)
                    doubleLinkedList.Add(new R1Point(point.GetXCoordinate() - i * SharedDirection.Divisor));
            // Going right.
            else
                for (int i = 1; i <= SharedDirection.DirectionLength / SharedDirection.Divisor; i++)
                    doubleLinkedList.Add(new R1Point(point.GetXCoordinate() + i * SharedDirection.Divisor));
        }

        // Will always return  true for a one dimensional direction.
        public override bool IsDirectionDimensionCorrect()
        {
            return Dimension == 1;
        }

        // Determines whether or not a direction is within the boundaries.
        public override bool IsDirectionValid(int direction)
        {
            return direction == 1 || direction == 2;
        }

        // Checkes whether or not points making up a direction have a correct dimension.
        public override bool IsPointDimensionCorrect()
        {
            return StartingPoint.Dimension == 1;
        }

        // Only reflect about the origin. That is axisIndex 1.
        public override R1NonCircularDirection ReflectAboutAxis(int axisIndex)
        {
            if (axisIndex == 1)
            {
                direction = (direction * -1);
            }


            return new R1NonCircularDirection(new R1Point(StartingPoint), direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, NumberOfRepeatations);
        }

        // The method is unsupported for a one dimensional direction. 
        // However the method will return a non reflection of this current object.
        public override R1NonCircularDirection ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            return new R1NonCircularDirection(new R1Point(StartingPoint), direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, numberOfTimes);
        }

        /* The method is unsupported for a one dimensional direction. 
           However the method will return a non reflection of the current object.
           For the rotate method this R1CircularDirection instance will be returned because in R1 rotation isn't applicable.*/
        public override R1NonCircularDirection RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            return new R1NonCircularDirection(new R1Point(StartingPoint), direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, numberOfTimes);
        }

        // The method is unsupported for a one dimensional direction. 
        // However the method will return a non reflection of this current object.
        public override R1NonCircularDirection RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            return new R1NonCircularDirection(new R1Point(StartingPoint), direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, numberOfTimes);
        }

        // Move direction.
        // Change the starting position on a direction.
        public override R1NonCircularDirection translate(int coordinateSystemDirection, float amount)
        {
            R1CircularDirection initialDirection = new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration,NumberOfRepeatations);

            float initialX = initialDirection.StartingPoint.GetAxisAt(0);

            float finalX = initialX;



            switch (coordinateSystemDirection)
            {
                case 1:
                    finalX -= amount;

                    break;
                default:
                    finalX += amount;
                    break;
            }



            return new R1NonCircularDirection(new R1Point(finalX),
                                            Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration,NumberOfRepeatations);
        }

        public override int CompareTo(R1NonCircularDirection comparableInstance)
        {
            throw new NotImplementedException();
        }

        public override PointIterator<R1Point> RetrievePointIterator()
        {
            throw new NotImplementedException();
        }

        public override R1NonCircularDirection ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }
    }
}
