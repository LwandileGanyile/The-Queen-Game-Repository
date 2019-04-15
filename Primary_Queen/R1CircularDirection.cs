using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;
using CircularIteration;
using SharedResources;

namespace Primary_Queen
{
    public class R1CircularDirection : CircularDirection<R1CircularDirection, R1Point>,IFill
    {
       

        public R1CircularDirection()
        :base(){
            StartingPoint = new R1Point().Position;
            dimension = 1;

            Fill();
            FillCanShootList();
            FillDuration();
            
        }


        // Construct without specifying the number of rotations.
        public R1CircularDirection(R1Point startingPoint, int direction, float directionLength,
        float directionDivisor,  Dictionary<int, int> duration)
        : base(startingPoint.Position, direction, directionLength, directionDivisor, new List<bool>(), duration,1)
        {
            Fill();
            FillCanShootList();
        }

        // Construct by specifying the number of rotations.
        public R1CircularDirection(R1Point startingPoint, int direction, float directionLength,
        float directionDivisor,  Dictionary<int, int> duration,  int numberOfRotations)
        : base(startingPoint.Position, direction, directionLength,
        directionDivisor, new List<bool>(), duration, 1, numberOfRotations)
        {
            Fill();
            FillCanShootList();
        }


        // Add points making up this direction.
        // Directio 1 --> Right +x.
        // Any direction value correspond to Direction 2 --> Left -x.

        /* The method suppose to be on the static R1Direction class. However i can't because
        I don't understand whether or not wildcard generics are supported in C#, if they are,
        how to use them.*/
        public void Fill()
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
            return R1Direction<R1CircularDirection, CircularLinkedList<R1Point>, CircularDirection<R1CircularDirection, R1Point>>.IsDirectionDimensionCorrect(Dimension); ;
        }

        // Determines whether or not a direction is within the boundaries.
        public override bool IsDirectionValid(int direction)
        {
            return direction == 1 || direction == 2;
        }

        // Checkes whether or not points making up a direction have a correct dimension.
        public override bool IsPointDimensionCorrect()
        {

            return R1Direction<R1CircularDirection, CircularLinkedList<R1Point>, CircularDirection<R1CircularDirection, R1Point>>.IsPointDimensionCorrect(StartingPoint);
        }

        // Only reflect about the origin. That is axisIndex 1.
        public override R1CircularDirection ReflectAboutAxis(int axisIndex)
        {

            R1Direction<R1CircularDirection, CircularLinkedList<R1Point>, CircularDirection<R1CircularDirection, R1Point>>.ReflectAboutAxis(axisIndex, ref direction);

            if(axisIndex==0)
                return new R1CircularDirection(new R1Point(StartingPoint), (Direction==1)?2:1, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration,numberOfRotations); 
            else
                return new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, numberOfRotations);
        }

        // The method is unsupported for a one dimensional direction. 
        // However the method will return a non reflection of this current object.
        public override R1CircularDirection ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
          
            return new R1CircularDirection(new R1Point(StartingPoint),Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, numberOfRotations);
           
        }

        /* The method is unsupported for a one dimensional direction. 
           However the method will return a non reflection of the current object.
           For the rotate method this R1CircularDirection instance will be returned because in R1 rotation isn't applicable.*/
        public override R1CircularDirection RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            return new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, numberOfRotations);
        }

        // The method is unsupported for a one dimensional direction. 
        // However the method will return a non reflection of this current object.
        public override R1CircularDirection RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            return new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, numberOfRotations);
        }

        // Move direction.
        // Change the starting position on a direction.
        public override R1CircularDirection translate(int coordinateSystemDirection, float amount)
        {

            float finalX = StartingPoint.GetAxisAt(0);

            R1Direction<R1CircularDirection,CircularLinkedList<R1Point>, CircularDirection<R1CircularDirection, R1Point>>.Translate(coordinateSystemDirection, amount, ref finalX);

            return new R1CircularDirection(new R1Point(finalX),
                                            Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration,numberOfRotations);

        }

        // Displays an R1CircularDirection. However the method suppose to be on a super class "CircularDirection".

        /* The method suppose to be on the static R1Direction class. However i can't because
        I don't understand whether or not wildcard generics are supported in C#, if they are,
        how to use them.*/
        public override void Display()
        {
            for (int i = 0; i < circularLinkedList.Size; i++)
            {
                circularLinkedList.GetAt(i).Display();
                if (i != circularLinkedList.Size - 1)
                    Console.Write(" , ");
            }

        }

        // Return an itertator for points.
        public override PointIterator<R1Point> RetrievePointIterator()
        {
            
            return new PointIterator<R1Point>(0,circularLinkedList);
        }

        // String representation of this circular direction.
        public override string ToString()
        {
            string output = base.ToString()+"\n";

            return output+circularLinkedList.ToString()+"\nNumber Of rotations : "+ numberOfRotations;
        }

        // Comparing two objects of this class.
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

        // Can't be implemented.
        public override R1CircularDirection ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            return new R1CircularDirection(new R1Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, Duration, numberOfRotations);
        }
    }
}
