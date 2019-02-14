using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;
using CircularIteration;

namespace Primary_Queen
{
    public class R1CircularDirection : CircularDirection<R1CircularDirection, R1Point>
    {
        public R1CircularDirection()
        :base(){
            StartingPoint = new R1Point().Position;
            dimension = 1;

            Fill();
            FillCanShootList();
            FillDuration();
        }

        // Construct without specifying the  length property cause it doesnh't exist.
        public R1CircularDirection(R1Point startingPoint, int direction,
        float directionDivisor, Dictionary<int,int> duration)
        : base(startingPoint.Position, direction, directionDivisor, new List<bool>(), duration, 1)
        {
            Fill();
            FillCanShootList();
        }

        // Construct without specifying the number of rotations.
        public R1CircularDirection(R1Point startingPoint, int direction, float directionLength,
        float directionDivisor, Dictionary<int,int> duration)
        : base(startingPoint.Position, direction, directionLength, directionDivisor, new List<bool>(), duration, 1, 1)
        {
            Fill();
            FillCanShootList();
        }

        // Construct by specifying the number of rotations.
        public R1CircularDirection(R1Point startingPoint, int direction, float directionLength,
                                  float directionDivisor, Dictionary<int,int> duration
                                  , int numberOfRotations)
        : base(startingPoint.Position, direction, directionDivisor, new List<bool>(), duration, numberOfRotations)
        {
            Fill();
            FillCanShootList();
        }

        

        // Add points making up this direction.
        // Directio 1 --> Right +x.
        // Any direction value correspond to Direction 2 --> Left -x.
        public override void Fill()
        {
            for (int numberOfTimes = 1; numberOfTimes <= numberOfRotations; numberOfTimes++)
            {
                R1Point point = new R1Point(_startingPoint);
                circularLinkedList.Add(point);

                // Going left.
                if (Direction == 1)
                    for (int i = 1; i <= SharedDirection.DirectionLength / SharedDirection.Divisor; i++)
                        circularLinkedList.Add(new R1Point(point.GetXCoordinate() - i * SharedDirection.Divisor));
                // Going right.
                else
                    for (int i = 1; i <= SharedDirection.DirectionLength / SharedDirection.Divisor; i++)
                        circularLinkedList.Add(new R1Point(point.GetXCoordinate() + i * SharedDirection.Divisor));
            }
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
        public override R1CircularDirection ReflectAboutAxis(int axisIndex)
        {

            if (axisIndex == 1)
            {
                if(direction == 1)
                    direction = 2;
                else if(direction == 2)
                    direction = 1;
            }


            return new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration); 
        }

        // The method is unsupported for a one dimensional direction. 
        // However the method will return a non reflection of this current object.
        public override R1CircularDirection ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            return new R1CircularDirection(new R1Point(StartingPoint),Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration);
        }

        /* The method is unsupported for a one dimensional direction. 
           However the method will return a non reflection of the current object.
           For the rotate method this R1CircularDirection instance will be returned because in R1 rotation isn't applicable.*/
        public override R1CircularDirection RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            return new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration);
        }

        // The method is unsupported for a one dimensional direction. 
        // However the method will return a non reflection of this current object.
        public override R1CircularDirection RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            return new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration);
        }

        // Move direction.
        // Change the starting position on a direction.
        public override R1CircularDirection translate(int coordinateSystemDirection, float amount)
        {

            R1CircularDirection initialDirection = new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration);

            float initialX = initialDirection.StartingPoint.GetAxisAt(0);

            float finalX = initialX;

            if (amount < 0)
                amount *= -1;

            switch (coordinateSystemDirection)
            {
                case 1:
                    finalX -= amount;

                    break;
                default:
                    finalX += amount;
                    break;

            }

            return new R1CircularDirection(new R1Point(finalX),
                                            Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration);

        }

        // Displays an R1CircularDirection. However the method suppose to be on a super class "CircularDirection".
        public override void Display()
        {
            for (int i = 0; i < circularLinkedList.Size; i++)
            {
                circularLinkedList.GetAt(i).Display();
                if (i != circularLinkedList.Size - 1)
                    Console.Write(" , ");
            }

        }

        public override PointIterator<R1Point> RetrievePointIterator()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            string output = base.ToString()+"\n";

            return output+circularLinkedList.ToString()+"\nNumber Of rotations : "+numberOfRotations;
        }

        public override int CompareTo(R1CircularDirection comparableInstance)
        {
            int result = 0;

            if (GetDirectionLength()<comparableInstance.GetDirectionLength())
            {
                result = -1;
            }

            else if (GetDirectionLength() > comparableInstance.GetDirectionLength())
            {
                result = 1;
            }

            else
            {
                if (GetDirectionDivisor() < comparableInstance.GetDirectionDivisor())
                {
                    result = -1;
                }

                else if (GetDirectionDivisor() > comparableInstance.GetDirectionDivisor())
                {
                    result = 1;
                }

                else
                {
                    if (Direction < comparableInstance.Direction)
                    {
                        result = -1;
                    }

                    else if (Direction > comparableInstance.Direction)
                    {
                        result = 1;
                    }

                    else
                    {
                        result = StartingPoint.CompareTo(comparableInstance.StartingPoint);
                    }
                }
            }

            return result;
        }

        
    }
}
