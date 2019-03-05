using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace Secondary_Queen
{
    // U is the datatype of a calling class.
    // V is either a circular or double linked list.
    // W is a base class for V.
    public class R2Direction<U, V, W>
    {
        public R2Direction()
        {

        }

        // Construct without specifying the length property.
        public R2Direction(R2Point startingPoint, int direction,
        float directionDivisor, Dictionary<int, int> duration)

        {

        }

        // Construct without specifying the number of rotations.
        public R2Direction(R2Point startingPoint, int direction, float directionLength,
        float directionDivisor, Dictionary<int, int> duration)

        {

        }

        // Construct by specifying the number of rotations.
        public R2Direction(R2Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int, int> duration, int numberOfRotations)

        {

        }

        // Rotate about the  x-axis or y-axis a certatin number of times, and return the result.
        // Rotate around the x-axis or the y-axis.
        public static void RotateAroundAxis(int indexOfAxis, int numberOfTimes, U direction)
        {


            for (int index = 1; index <= numberOfTimes; index++)
            {

                //direction = direction.ReflectAboutAxis(indexOfAxis);
            }

            
        }

        // Reflect about the  x-axis or y-axis, and return the result.
        // 0 means x-axis, 1 means y-axis.
        public static void ReflectAboutAxis(int axisIndex,ref int direction)
        {


            if (axisIndex == 0)
            {
                switch (direction)
                {
                    case 1:
                        direction = 1;
                        break;
                    case 2:
                        direction = 3;
                        break;
                    case 3:
                        direction = 2;
                        break;
                    case 4:
                        direction = 7;
                        break;
                    case 5:
                        direction = 6;
                        break;
                    case 6:
                        direction = 5;
                        break;
                    case 7:
                        direction = 4;
                        break;
                    case 8:
                        direction = 8;
                        break;
                }
            }
            else if (axisIndex == 1)
            {
                switch (direction)
                {
                    case 1:
                        direction = 8;
                        break;
                    case 2:
                        direction = 2;
                        break;
                    case 3:
                        direction = 3;
                        break;
                    case 4:
                        direction = 6;
                        break;
                    case 5:
                        direction = 7;
                        break;
                    case 6:
                        direction = 4;
                        break;
                    case 7:
                        direction = 5;
                        break;
                    case 8:
                        direction = 8;
                        break;
                }
            }


            
        }

        // Reflect about the  line y = x or y = -x a certain number of times, and return the result.
        // A negetive element means on the negetive side of the axis.
        public static void ReflectAboutEqualAxis(List<int> axisIndeces, int numberOfTimes,ref int direction)
        {

            for (int i = 0; i < numberOfTimes; i++)
            {
                if ((axisIndeces[0] == 1 && axisIndeces[1] == 1) || (axisIndeces[0] == -1 && axisIndeces[1] == -1))
                {
                    switch (direction)
                    {
                        case 1:
                            direction = 3;
                            break;
                        case 2:
                            direction = 8;
                            break;
                        case 3:
                            direction = 1;
                            break;
                        case 4:
                            direction = 5;
                            break;
                        case 5:
                            direction = 4;
                            break;
                        case 6:
                            direction = 6;
                            break;
                        case 7:
                            direction = 7;
                            break;
                        case 8:
                            direction = 2;
                            break;
                    }
                }

                else if ((axisIndeces[0] == -1 && axisIndeces[1] == 1) || (axisIndeces[0] == 1 && axisIndeces[1] == -1))
                {
                    switch (direction)
                    {
                        case 1:
                            direction = 2;
                            break;
                        case 2:
                            direction = 1;
                            break;
                        case 3:
                            direction = 8;
                            break;
                        case 4:
                            direction = 4;
                            break;
                        case 5:
                            direction = 5;
                            break;
                        case 6:
                            direction = 7;
                            break;
                        case 7:
                            direction = 6;
                            break;
                        case 8:
                            direction = 3;
                            break;
                    }
                }

                
            }
           
        }

        public static void ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes, ref int direction)
        {
            ReflectAboutEqualAxis(axisIndeces, numberOfTimes, ref direction);
        }

        // Determines whether or not a direction is within the boundaries.
        public static bool IsDirectionValid(int direction)
        {
            return direction >= 1 && direction <= 8;
        }

        // Move direction.
        // Change the starting position on a direction.
        public static void Translate(int coordinateSystemDirection, float amount, float finalX, float finalY)
        {

            switch (coordinateSystemDirection)
            {
                case 1:
                    finalX -= amount;

                    break;
                case 2:
                    finalY += amount;

                    break;
                case 3:
                    finalY -= amount;

                    break;
                case 4:
                    finalX -= amount;
                    finalY += amount;

                    break;
                case 5:
                    finalX += amount;
                    finalY -= amount;

                    break;
                case 6:
                    finalX += amount;
                    finalY += amount;

                    break;
                case 7:
                    finalX -= amount;
                    finalY -= amount;

                    break;
                case 8:
                    finalX += amount;

                    break;
            }

            
        }

        // Will always return  true for a one dimensional direction.
        public static bool IsDirectionDimensionCorrect(int dimension)
        {
            return dimension == 2;
        }

        // Checkes whether or not points making up a direction have a correct dimension.
        public static bool IsPointDimensionCorrect(Point startingPoint)
        {
            return startingPoint.Dimension == 2;
        }

        // Displays an R1CircularDirection.
        /*public static void Display()
        {
            for (int i = 0; i < circularLinkedList.Size; i++)
            {
                circularLinkedList.GetAt(i).Display();
                if (i != circularLinkedList.Size - 1)
                    Console.Write(" , ");
            }

        }*/

        /*public static void Fill()
        {
            for (int numberOfTimes = 1; numberOfTimes <= numberOfRotations; numberOfTimes++)
            {
                R2Point point = new R2Point(_startingPoint);
                circularLinkedList.Add(point);

                // Going left.
                if (Direction == 1)
                    for (int i = 1; i <= SharedDirection.DirectionLength / SharedDirection.Divisor; i++)
                        circularLinkedList.Add(new R2Point(point.GetXCoordinate() - i * SharedDirection.Divisor));
                // Going right.
                else
                    for (int i = 1; i <= SharedDirection.DirectionLength / SharedDirection.Divisor; i++)
                        circularLinkedList.Add(new R2Point(point.GetXCoordinate() + i * SharedDirection.Divisor));
            }
        }*/

        // Comparing two objects of this class.
        /* public static int CompareTo(U comparableInstance)
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
         }*/

        // String representation of this circular direction.
        public static string ToString(V list, W baseClass, int numberOfRotations)
        {
            string output = baseClass.ToString() + "\n";

            return output + list.ToString() + "\nNumber Of rotations : " + numberOfRotations;
        }

        
    }
}
