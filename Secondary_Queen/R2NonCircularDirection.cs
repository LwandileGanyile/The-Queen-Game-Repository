﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;
using NonCircularIteration;
using SharedResources;

namespace Secondary_Queen
{
    public class R2NonCircularDirection : NonCircularDirection<R2NonCircularDirection,R2Point>
    {
        public R2NonCircularDirection():base()
        {

            _startingPoint = new R2Point().Position;
            dimension = 2;

            Fill();
            FillCanShootList();
            
        }

        // Construct without specifying the canshoot property.
        public R2NonCircularDirection(R2Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int, int> duration, int numberOfRotations)
        : base(startingPoint.Position, direction, divisor,directionLength,duration,2,numberOfRotations)
        {
            Fill();
            FillCanShootList();
        }

        // Construct without specifying the canshoot property.
        public R2NonCircularDirection(R2Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int, int> duration)
        : base(startingPoint.Position, direction, divisor, directionLength,duration,2,1)
        {
            Fill();
            FillCanShootList();
        }


        // Construct without specifying the  length property cause it doesn't exist.
        public R2NonCircularDirection(R2Point startingPoint, int direction,
        float directionDivisor, List<bool> canShootList, Dictionary<int, int> duration)
        : base(startingPoint.Position, direction, directionDivisor, canShootList, duration, 2)
        {

            Fill();

        }

        // Construct without specifying the number of rotations.
        public R2NonCircularDirection(R2Point startingPoint, int direction, float directionLength, float directionDivisor, List<bool> canShootList, Dictionary<int, int> duration)
        : base(startingPoint.Position, direction, directionLength, directionDivisor, canShootList, duration, 2)
        {

            Fill();

        }

        // Construct by specifying the number of rotations.
        public R2NonCircularDirection(R2Point startingPoint, int direction, float directionLength, float divisor, List<bool> canShootList, Dictionary<int, int> duration, int numberOfRotations)
        : base(startingPoint.Position, direction, directionLength,divisor, canShootList,duration, 2, numberOfRotations)
        {

            Fill();

        }


        // Add points making up this direction.
        // Directio 1-7.
        // Any direction value correspond to Direction 8.
        public void Fill()
        {
            R2Point point = new R2Point(StartingPoint);
            int numberOfElements = (int)(SharedDirection.DirectionLength / SharedDirection.Divisor);

            doubleLinkedList.Add(point);



            switch (direction)
            {
                case 1:
                    for (int i = 1; i <= numberOfElements; i++)
                        doubleLinkedList.Add(new R2Point(point.GetXCoordinate() - i * SharedDirection.Divisor, point.GetYCoordinate()));
                    break;
                case 2:

                    for (int i = 1; i <= numberOfElements; i++)
                        doubleLinkedList.Add(new R2Point(point.GetXCoordinate(), point.GetYCoordinate() + i * SharedDirection.Divisor));

                    break;
                case 3:

                    for (int i = 1; i <= numberOfElements; i++)
                        doubleLinkedList.Add(new R2Point(point.GetXCoordinate(), point.GetYCoordinate() - i * SharedDirection.Divisor));

                    break;
                case 4:

                    for (int i = 1; i <= numberOfElements; i++)
                        doubleLinkedList.Add(new R2Point(point.GetXCoordinate() - i * SharedDirection.Divisor, point.GetYCoordinate() + i * SharedDirection.Divisor));

                    break;
                case 5:

                    for (int i = 1; i <= numberOfElements; i++)
                        doubleLinkedList.Add(new R2Point(point.GetXCoordinate() + i * SharedDirection.Divisor, point.GetYCoordinate() - i * SharedDirection.Divisor));

                    break;
                case 6:

                    for (int i = 1; i <= numberOfElements; i++)
                        doubleLinkedList.Add(new R2Point(point.GetXCoordinate() + i * SharedDirection.Divisor, point.GetYCoordinate() + i * SharedDirection.Divisor));

                    break;
                case 7:

                    for (int i = 1; i <= numberOfElements; i++)
                        doubleLinkedList.Add(new R2Point(point.GetXCoordinate() - i * SharedDirection.Divisor, point.GetYCoordinate() - i * SharedDirection.Divisor));

                    break;
                case 8:

                    for (int i = 1; i <= numberOfElements; i++)
                        doubleLinkedList.Add(new R2Point(point.GetXCoordinate() + i * SharedDirection.Divisor, point.GetYCoordinate()));

                    break;

            }
        }

        // Will always return true for a two dimensional direction.
        public override bool IsDirectionDimensionCorrect()
        {
            return R2Direction<R2NonCircularDirection, DoubleLinkedList<R2Point>, 
            NonCircularDirection<R2NonCircularDirection, R2Point>>.IsDirectionDimensionCorrect(dimension);
        }

        // Determines whether or not a direction is within the boundaries..
        public override bool IsDirectionValid(int direction)
        {
            return R2Direction<R2NonCircularDirection, DoubleLinkedList<R2Point>,
            NonCircularDirection<R2NonCircularDirection, R2Point>>.IsDirectionValid(direction);
        }

        // Checkes whether or not points making up a direction have a correct dimension.
        public override bool IsPointDimensionCorrect()
        {
            return R2Direction<R2NonCircularDirection, DoubleLinkedList<R2Point>,
            NonCircularDirection<R2NonCircularDirection, R2Point>>.IsPointDimensionCorrect(StartingPoint);
        }

        // Reflect about the  x-axis or y-axis, and return the result.
        // 0 means x-axis, 1 means y-axis.
        public override R2NonCircularDirection ReflectAboutAxis(int axisIndex)
        {


            R2Direction<R2NonCircularDirection, DoubleLinkedList<R2Point>, NonCircularDirection<R2NonCircularDirection, R2Point>>.ReflectAboutAxis(axisIndex, ref direction);


            return new R2NonCircularDirection(new R2Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, canShootList, Duration);
        }

        // Reflect about the  line y = x or y = -x a certain number of times, and return the result.
        // A negetive element means on the negetive side of the axis.
        public override R2NonCircularDirection ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {


            R2Direction<R2NonCircularDirection, DoubleLinkedList<R2Point>, NonCircularDirection<R2NonCircularDirection, R2Point>>.ReflectAroundEqualAxis(axisIndeces, numberOfTimes, ref direction);

            return new R2NonCircularDirection(new R2Point(StartingPoint.GetAxisAt(0), StartingPoint.GetAxisAt(1),StartingPoint.CanShoot),
                                            Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, CanShoot, Duration);

           
        }

        // Rotate about the  x-axis or y-axis a certatin number of times, and return the result.
        // Rotate around the x-axis or the y-axis.
        public override R2NonCircularDirection RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {

            R2NonCircularDirection direction = this;



            R2Direction<R2NonCircularDirection, DoubleLinkedList<R2Point>, NonCircularDirection<R2NonCircularDirection, R2Point>>.RotateAroundAxis(indexOfAxis, numberOfTimes, direction);

            return new R2NonCircularDirection(new R2Point(StartingPoint.GetAxisAt(0), StartingPoint.GetAxisAt(1), StartingPoint.CanShoot),
                                            Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, CanShoot, Duration);
        }

        // Rotate about the  line y = x or y = -x a certain number of times, and return the result.
        // Rotate about y = x and y = -x.
        public override R2NonCircularDirection RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            return ReflectAroundEqualAxis(indecesOfAxis, numberOfTimes);
        }

        // Move direction.
        // Change the starting position on a direction.
        public override R2NonCircularDirection translate(int coordinateSystemDirection, float amount)
        {

            R2NonCircularDirection initialDirection = new R2NonCircularDirection(new R2Point(StartingPoint), Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, canShootList, Duration);

            float finalX = initialDirection.StartingPoint.GetAxisAt(0);
            float finalY = initialDirection.StartingPoint.GetAxisAt(1);


            R2Direction<R2NonCircularDirection, DoubleLinkedList<R2Point>, NonCircularDirection<R2NonCircularDirection, R2Point>>.Translate(coordinateSystemDirection, amount, finalX, finalY);

            return new R2NonCircularDirection(new R2Point(finalX, finalY, initialDirection.StartingPoint.CanShoot),
                                            Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, CanShoot, Duration);
        }

        // Print the direction on a console.
        public override void Display()
        {
            for (int i = 0; i < doubleLinkedList.Size; i++)
            {
                doubleLinkedList.GetAt(i).Display();
                if (i != doubleLinkedList.Size - 1)
                    Console.Write(" , ");
            }

        }

        public override PointIterator<R2Point> RetrievePointIterator()
        {
            return new PointIterator<R2Point>(0,doubleLinkedList);
        }

        public override int CompareTo(R2NonCircularDirection comparableInstance)
        {
            int result = 0;

            if (GetDirectionLength() < comparableInstance.GetDirectionLength())
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

        public override R2NonCircularDirection ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            R2Direction<R2NonCircularDirection, DoubleLinkedList<R2Point>, NonCircularDirection<R2NonCircularDirection, R2Point>>.ReflectAroundEqualAxis(new List<int>(axisIndeces), numberOfTimes, ref direction);

            return new R2NonCircularDirection(new R2Point(StartingPoint.GetAxisAt(0), StartingPoint.GetAxisAt(1),StartingPoint.CanShoot),
                                            Direction, SharedDirection.DirectionLength, SharedDirection.Divisor, CanShoot, Duration);
        }
    }
}

