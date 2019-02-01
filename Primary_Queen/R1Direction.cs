using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary_Queen
{
    public class R1Direction
    {


        // Construct without specifying the length property.
        public R1Direction(R1Point startingPoint, int direction,
        float directionDivisor, Dictionary<int, int> duration)
       
        {
         
        }

        // Construct without specifying the number of rotations.
        public R1Direction(R1Point startingPoint, int direction, float directionLength,
        float directionDivisor, Dictionary<int, int> duration)
        
        {
       
        }

        // Construct by specifying the number of rotations.
        public R1Direction(R1Point startingPoint, int direction, float directionLength,
        float divisor, Dictionary<int, int> duration, int numberOfRotations)
       
        {
          
        }



        // Determines whether or not a direction is within the boundaries.
        public bool IsDirectionValid(int direction)
        {
            return direction == 1 || direction == 2;
        }

        // The set the values for the translate method.
        public float TranslatePartially(int coordinateSystemDirection, float amount, float initialX)
        {

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

            return finalX;
  
        }
    }
}
