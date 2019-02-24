using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Queen
{
    public class ThirtheenthPlanePerspective : ITransformation<R3Plane>, IR3Plane
    {

        public ThirtheenthPlanePerspective()
        {
            
        }

        public ThirtheenthPlanePerspective(R3Point planeCenter, int planeNumber)
        
        {
           
        }

        public ThirtheenthPlanePerspective(R3Point planeCenter, int planeNumber, NumberOFPlanes numberOfPlanes)
        
        {
           
        }

        // Same code appears on the NinethPlanePerspective.
        public R3Plane ReflectAboutAxis(int axisIndex, R3Point planeCentre, int planeNumber)
        {
            float newXCoordinate = planeCentre.Position.GetAxisAt(0);
            float newYCoordinate = planeCentre.Position.GetAxisAt(1);
            float newZCoordinate = planeCentre.Position.GetAxisAt(2);

            if (axisIndex == 1)
                newYCoordinate = -planeCentre.Position.GetAxisAt(1);

            else if (axisIndex == 2)
                newXCoordinate = -planeCentre.Position.GetAxisAt(0);

            else if (axisIndex == 3)
                newZCoordinate = -planeCentre.Position.GetAxisAt(2);

            return new R3Plane(new R3Point(newXCoordinate, newYCoordinate, newZCoordinate), planeNumber);
        }

        // Same code appears on the NinethPlanePerspective, 
        // however its only for plane number 1 through plane number 5, plane 10 and plane 11.
        public R3Plane ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes, R3Point planeCentre, NumberOFPlanes numberOfPlanes, int planeNumber)
        {

            if (numberOfPlanes==NumberOFPlanes.Fiftheen_Planes)
            {
                return DealWith15PlanesReflection(axisIndeces, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
            }

            else if (numberOfPlanes == NumberOFPlanes.Eleven_Planes)
            {
                return DealWith11PlanesReflection(axisIndeces, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
            }

            else
                return DealWith9PlanesReflection(axisIndeces, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);


        }

        public R3Plane RotateAroundAxis(int indexOfAxis, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre, int planeNumber)
        {


            if (numberOfPlanes == NumberOFPlanes.Fiftheen_Planes)
            {
                return DealWith15PlanesRotation(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
            }

            else if (numberOfPlanes == NumberOFPlanes.Eleven_Planes)
            {
                return DealWith11PlanesRotation(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
            }

            else
                return DealWith9PlanesRotation(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);


            
        }



        /* The code is duplicated for case 1 to case 5, and the subsequent cases up to case 9 are the opposite on the NinethPlanePerspective.*/
         
        public R3Plane DealWith9PlanesReflection(int[] axisIndeces, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {
            float newXCoordinate = planeCentre.Position.GetAxisAt(0);
            float newYCoordinate = planeCentre.Position.GetAxisAt(1);
            float newZCoordinate = planeCentre.Position.GetAxisAt(2);

            if (numberOfTimes % 2 != 0)
                switch (GetPlaneNumber(axisIndeces))
                {
                    case 1:
                        newZCoordinate = -planeCentre.Position.GetAxisAt(2);
                        break;
                    case 2:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(0);
                        break;
                    case 3:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(1);
                        newYCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                    case 4:
                        newYCoordinate = -planeCentre.Position.GetAxisAt(1);
                        break;
                    case 5:
                        newYCoordinate = planeCentre.Position.GetAxisAt(0);
                        newXCoordinate = planeCentre.Position.GetAxisAt(1);
                        break;
                    case 6:
                        newYCoordinate = -planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(1);
                        break;
                    case 7:
                        newYCoordinate = planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(1);

                        break;
                    case 8:
                        newXCoordinate = planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                    case 9:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                }

            return new R3Plane(new R3Point(newXCoordinate, newYCoordinate, newZCoordinate), planeNumber, numberOfPlanes);
        }

        public R3Plane DealWith9PlanesRotation(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {
            

            // Rotate around z axis.
            if (indexOfAxis == 2)
            {
               return  Rotate9AroundZAxis(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
            }

            // Rotate around y axis.
            else if (indexOfAxis == 1)
            {
               return Rotate9AroundYAxis(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
            }

            // Rotate around x axis.
            else
            {
               return Rotate9AroundXAxis(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
            }

           
        }

        private R3Plane Rotate9AroundXAxis(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {

            int newPlaneNumber;

            switch (planeNumber)
            {
                case 1:
                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 7;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 4;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 6;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }
                    break;
                case 2:
                 
                    newPlaneNumber = planeNumber;

                    break;
                case 3:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5 || numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 1;
                    }

                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0 || numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 4:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 6;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 2;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 7;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 5:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5 || numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 1;
                    }

                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0 || numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 6:
                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 1;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 7;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 4;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }
                    break;
                case 7:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 4;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 6;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 1;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 8:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5 || numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 4;
                    }

                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0 || numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = planeNumber;
                    }


                    break;
                case 9:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5 || numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 4;
                    }

                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0 || numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = planeNumber;
                    }


                    break;
            }

            return new R3Plane(planeCentre, planeNumber, numberOfPlanes);
        }

        private R3Plane Rotate9AroundYAxis(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {

            int newPlaneNumber;

            switch (planeNumber)
            {
                case 1:
                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 9;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 2;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 8;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }
                    break;
                case 2:
                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 9;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 1;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 8;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }
                    break;
                case 3:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5 || numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 1;
                    }
                   
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0 || numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 4:

                    newPlaneNumber = planeNumber;
                    
                    break;
                case 5:

                    newPlaneNumber = planeNumber;

                    break;
                case 6:
                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5 || numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 2;
                    }
                                                                                                    
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0 || numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = planeNumber;
                    }
                    break;
                case 7:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5 || numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 2;
                    }
                    
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0 || numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 8:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 1;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 9;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 2;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 9:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 2;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 8;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 1;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
            }

            return new R3Plane(planeCentre, planeNumber, numberOfPlanes);
        }

        private R3Plane Rotate9AroundZAxis(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {

            int newPlaneNumber;

            switch (planeNumber)
            {
                case 1:
                    newPlaneNumber = planeNumber;
                    break;
                case 2:
                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 5;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 4;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 3;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }
                    break;
                case 3:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 2;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 5;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 4;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 4:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 3;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 2;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 5;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 5:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 2;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 3;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 4;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 6:
                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 8;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 9;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 7;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }
                    break;
                case 7:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 8;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 9;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 6;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 8:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 8;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 6;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 9;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
                case 9:

                    if (numberOfTimes % 8 == 1 || numberOfTimes % 8 == 5)
                    {
                        newPlaneNumber = 7;
                    }
                    else if (numberOfTimes % 8 == 2 || numberOfTimes % 8 == 6)
                    {
                        newPlaneNumber = 8;
                    }
                    else if (numberOfTimes % 8 == 3 || numberOfTimes % 8 == 7)
                    {
                        newPlaneNumber = 6;
                    }
                    else if (numberOfTimes % 8 == 4 || numberOfTimes % 8 == 0)
                    {
                        newPlaneNumber = planeNumber;
                    }

                    break;
            }

            return new R3Plane(planeCentre, planeNumber, numberOfPlanes);
        }

        public R3Plane DealWith11PlanesRotation(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {



            return null;
        }

        /* The code is duplicated for case 1 to case 5, and the subsequent cases up to case 9 are the opposite on the NinethPlanePerspective.
         The very same thing applies for case 10 and case 11, they are duplicated too. Case 12 & case 13 are the opposite on the
        NinethPlanePerspective.*/
        public R3Plane DealWith11PlanesReflection(int[] axisIndeces, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {
            float newXCoordinate = planeCentre.Position.GetAxisAt(0);
            float newYCoordinate = planeCentre.Position.GetAxisAt(1);
            float newZCoordinate = planeCentre.Position.GetAxisAt(2);

            if (numberOfTimes % 2 != 0)
                switch (GetPlaneNumber(axisIndeces))
                {
                    case 1:
                        newZCoordinate = -planeCentre.Position.GetAxisAt(2);
                        break;
                    case 2:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(0);
                        break;
                    case 3:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(1);
                        newYCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                    case 4:
                        newYCoordinate = -planeCentre.Position.GetAxisAt(1);
                        break;
                    case 5:
                        newYCoordinate = planeCentre.Position.GetAxisAt(0);
                        newXCoordinate = planeCentre.Position.GetAxisAt(1);
                        break;
                    case 6:
                        newYCoordinate = -planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(1);
                        break;
                    case 7:
                        newYCoordinate = planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(1);

                        break;
                    case 8:
                        newXCoordinate = planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                    case 9:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                    case 10:
                        
                        newZCoordinate = -planeCentre.Position.GetAxisAt(2);
                        break;
                    case 11:
                        
                        newZCoordinate = -planeCentre.Position.GetAxisAt(2);
                        break;


                }

            return new R3Plane(new R3Point(newXCoordinate, newYCoordinate, newZCoordinate), planeNumber, numberOfPlanes);
        }


        public R3Plane DealWith15PlanesRotation(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {
            return null;

        }

        /* The code is duplicated for case 1 to case 5, and the subsequent cases up to case 9 are the opposite on the NinethPlanePerspective.
         The very same thing applies for case 10 and case 11, they are duplicated too. Case 14 & case 15, case 12 & case 13 are the opposite on the
        NinethPlanePerspective.*/
        public R3Plane DealWith15PlanesReflection(int[] axisIndeces, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes)
        {
            float newXCoordinate = planeCentre.Position.GetAxisAt(0);
            float newYCoordinate = planeCentre.Position.GetAxisAt(1);
            float newZCoordinate = planeCentre.Position.GetAxisAt(2);

            if (numberOfTimes % 2 != 0)
                switch (GetPlaneNumber(axisIndeces))
                {
                    case 1:
                        newZCoordinate = -planeCentre.Position.GetAxisAt(2);
                        break;
                    case 2:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(0);
                        break;
                    case 3:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(1);
                        newYCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                    case 4:
                        newYCoordinate = -planeCentre.Position.GetAxisAt(1);
                        break;
                    case 5:
                        newYCoordinate = planeCentre.Position.GetAxisAt(0);
                        newXCoordinate = planeCentre.Position.GetAxisAt(1);
                        break;
                    case 6:
                        newYCoordinate = -planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(1);
                        break;
                    case 7:
                        newYCoordinate = planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(1);

                        break;
                    case 8:
                        newXCoordinate = planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                    case 9:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(2);
                        newZCoordinate = planeCentre.Position.GetAxisAt(0);
                        break;
                    case 10:

                        newZCoordinate = -planeCentre.Position.GetAxisAt(2);
                        break;
                    case 11:

                        newZCoordinate = -planeCentre.Position.GetAxisAt(2);
                        break;
                    case 12:
                        newXCoordinate = planeCentre.Position.GetAxisAt(2);
                        newYCoordinate = planeCentre.Position.GetAxisAt(2);
                        break;
                    case 13:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(2);
                        newYCoordinate = -planeCentre.Position.GetAxisAt(2);
                       
                        break;
                    case 14:
                        newXCoordinate = -planeCentre.Position.GetAxisAt(2);
                        newYCoordinate = planeCentre.Position.GetAxisAt(2);
                       
                        break;
                    case 15:
                        newXCoordinate = planeCentre.Position.GetAxisAt(2);
                        newYCoordinate = -planeCentre.Position.GetAxisAt(2);
                        
                        break;

                }

            return new R3Plane(new R3Point(newXCoordinate, newYCoordinate, newZCoordinate), planeNumber,numberOfPlanes);
        }


        public int GetPlaneNumber(int[] axisIndeces)
        {
            int planeNumber = -1;

            // Direction 17 with resprect to the player.
            // +y +z 
            // +2 +3
            if (axisIndeces[0] == 2 && axisIndeces[1] == 3 ||
            axisIndeces[0] == 3 && axisIndeces[1] == 2)
            {
                planeNumber = 6;

            }

            // Direction 1 with resprect to the player.
            // +y -z
            // +2 -3
            else if (axisIndeces[0] == 2 && axisIndeces[1] == -3 ||
            axisIndeces[0] == -3 && axisIndeces[1] == 2)
            {
                planeNumber = 7;
            }

            // Direction 16 with resprect to the player.
            // +y -x
            // +2 -1
            else if (axisIndeces[0] == 2 && axisIndeces[1] == -1 ||
            axisIndeces[0] == -1 && axisIndeces[1] == 2)
            {
                planeNumber = 3;
            }


            // Direction 10 with resprect to the player.
            // +y +x
            // +2 +1
            else if (axisIndeces[0] == 2 && axisIndeces[1] == 1 ||
            axisIndeces[0] == 1 && axisIndeces[1] == 2)
            {
                planeNumber = 5;
            }



            // Direction 5 with resprect to the player.
            // -y -z
            // -2 -3
            else if (axisIndeces[0] == -2 && axisIndeces[1] == -3 ||
            axisIndeces[0] == -3 && axisIndeces[1] == -2)
            {
                planeNumber = 6;
            }


            // Direction 21 with resprect to the player.
            // -y +z
            // -2 +3
            else if (axisIndeces[0] == -2 && axisIndeces[1] == 3 ||
            axisIndeces[0] == 3 && axisIndeces[1] == -2)
            {
                planeNumber = 7;
            }


            // Direction 14 with resprect to the player.
            // -y -x
            // +2 -3
            else if (axisIndeces[0] == -2 && axisIndeces[1] == 1 ||
            axisIndeces[0] == 1 && axisIndeces[1] == -2)
            {
                planeNumber = 5;
            }


            // Direction 12 with resprect to the player.
            // -y +x
            else if (axisIndeces[0] == -2 && axisIndeces[1] == 1 ||
            axisIndeces[0] == 1 && axisIndeces[1] == -2)
            {
                planeNumber = 3;
            }

            // Direction 23 with resprect to the player.
            // +z -x
            else if (axisIndeces[0] == 3 && axisIndeces[1] == -1 ||
            axisIndeces[0] == -1 && axisIndeces[1] == 3)
            {
                planeNumber = 8;
            }

            // Direction 19 with resprect to the player.
            // +z +x
            else if (axisIndeces[0] == 3 && axisIndeces[1] == 1 ||
            axisIndeces[0] == 1 && axisIndeces[1] == 3)
            {
                planeNumber = 9;
            }


            // Direction 7 with resprect to the player.
            // -z -x
            else if (axisIndeces[0] == 3 && axisIndeces[1] == -1 ||
            axisIndeces[0] == -1 && axisIndeces[1] == 3)
            {
                planeNumber = 9;
            }


            // Direction 3 with resprect to the player.
            // z +x
            else if (axisIndeces[0] == 3 && axisIndeces[1] == 1 ||
            axisIndeces[0] == 1 && axisIndeces[1] == 3)
            {
                planeNumber = 8;
            }

            return planeNumber;
        }

        public R3Plane ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes, int planeNumber)
        {
            throw new NotImplementedException();
        }

        public void FillDirections()
        {
            throw new NotImplementedException();
        }
    }
}
