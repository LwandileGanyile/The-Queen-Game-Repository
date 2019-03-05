using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;
using BuildingBlocks;


namespace Primary_Queen
{

    // U is the datatype of a calling class.
    // V is either a circular or double linked list.
    // W is a base class for V.
    public class R1Direction<U, V, W>
    {
        private R1Direction()
        {

        }

        // Construct without specifying the length property.
        private R1Direction(R1Point startingPoint, int direction,
        float directionDivisor, Dictionary<int, int> duration)
       
        {
         
        }

        // Construct without specifying the number of rotations.
        private R1Direction(R1Point startingPoint, int direction, float directionLength,
        float directionDivisor, Dictionary<int, int> duration)
        
        {
       
        }

        // Construct by specifying the number of rotations.
        private R1Direction(R1Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int, int> duration, int numberOfRotations)
       
        {
          
        }



        // Only reflect about the origin. That is axisIndex 1.
        public static void ReflectAboutAxis(int axisIndex, ref int direction)
        {

            if (axisIndex == 1)
            {
                if (direction == 1)
                    direction = 2;
                else if (direction == 2)
                    direction = 1;
            }


            
        }

        // Determines whether or not a direction is within the boundaries.
        public static bool IsDirectionValid(int direction)
        {
            return direction == 1 || direction == 2;
        }

        // The set the values for the translate method.
        public static void Translate(int coordinateSystemDirection, float amount,  ref float initialX)
        {

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

            initialX = finalX;

            

        }

        // Will always return  true for a one dimensional direction.
        public static bool IsDirectionDimensionCorrect(int dimension)
        {
            return dimension == 1;
        }

        // Checkes whether or not points making up a direction have a correct dimension.
        public static bool IsPointDimensionCorrect(Point startingPoint)
        {
            return startingPoint.Dimension == 1;
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
