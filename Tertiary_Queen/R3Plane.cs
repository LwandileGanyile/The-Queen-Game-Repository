using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Pieces;

namespace Tertiary_Queen
{
   

    public class R3Plane:Plane
    {
        private IR3Plane planePerspective;
        protected NumberOFPlanes numberOfPlanes;

        public R3Plane()
        {
            numberOfPlanes = NumberOFPlanes.Nine_Planes;
        }

        public R3Plane(IR3Plane planePerspective)
        {
            numberOfPlanes = NumberOFPlanes.Nine_Planes;
        }

        public R3Plane(IR3Plane planePerspective, NumberOFPlanes numberOfPlanes)
        {
            numberOfPlanes = NumberOFPlanes.Nine_Planes;
            this.numberOfPlanes = numberOfPlanes;
        }

        public R3Plane(R3Point planeCenter,int planeNumber)
        :base(planeCenter.Position,3,planeNumber)
        {
            numberOfPlanes = NumberOFPlanes.Nine_Planes;
        }

        public R3Plane(R3Point planeCenter, int planeNumber, NumberOFPlanes numberOfPlanes)
        : base(planeCenter.Position, 3, planeNumber)
        {
            this.numberOfPlanes = numberOfPlanes;
        }

        public override Plane ReflectAboutAxis(int axisIndex)
        {

            return planePerspective.ReflectAboutAxis(axisIndex, new R3Point(planeCentre.GetAxisAt(0),
                                                                            planeCentre.GetAxisAt(1),
                                                                            planeCentre.GetAxisAt(2)), 
                                                                            planeNumber);

        }

        public override Plane ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            return planePerspective.ReflectAboutEqualAxis(axisIndeces, numberOfTimes, planeNumber);

        }

        public override Plane RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            return planePerspective.RotateAroundAxis(indexOfAxis, 
                                                    numberOfTimes, 
                                                    numberOfPlanes, 
                                                    new R3Point(planeCentre.GetAxisAt(0),
                                                               planeCentre.GetAxisAt(1),
                                                               planeCentre.GetAxisAt(2)), 
                                                               planeNumber);
        }

        public override void FillDirections()
        {
            planePerspective.FillDirections();
        }

        protected R3Plane DealWith9PlanesRotation(int indexOfAxis, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre)
        {
            return planePerspective.DealWith9PlanesRotation(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
        }

        protected R3Plane DealWith9PlanesReflection(int[] axisIndeces, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre)
        {
            return planePerspective.DealWith9PlanesReflection(axisIndeces, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
        }

        protected R3Plane DealWith11PlanesRotation(int indexOfAxis, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre)
        {
            return planePerspective.DealWith11PlanesRotation(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
        }

        protected R3Plane DealWith11PlanesReflection(int[] axisIndeces, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre)
        {
            return planePerspective.DealWith11PlanesReflection(axisIndeces, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
        }

        protected R3Plane DealWith15PlanesRotation(int indexOfAxis, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre)
        {
            return planePerspective.DealWith15PlanesRotation(indexOfAxis, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
        }

        protected R3Plane DealWith15PlanesReflection(int[] axisIndeces, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre)
        {
            return planePerspective.DealWith15PlanesReflection(axisIndeces, numberOfTimes, planeCentre, planeNumber, numberOfPlanes);
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
    }


}
