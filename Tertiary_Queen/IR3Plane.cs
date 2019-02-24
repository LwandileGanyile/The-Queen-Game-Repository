using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Queen
{
    public interface IR3Plane
    {
        R3Plane DealWith9PlanesRotation(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes);

        R3Plane DealWith11PlanesReflection(int[] axisIndeces, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes);

        R3Plane DealWith15PlanesRotation(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes);

        R3Plane DealWith9PlanesReflection(int[] axisIndeces, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes);

        R3Plane DealWith11PlanesRotation(int indexOfAxis, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes);

        R3Plane DealWith15PlanesReflection(int[] axisIndeces, int numberOfTimes, R3Point planeCentre, int planeNumber, NumberOFPlanes numberOfPlanes);

        R3Plane ReflectAboutAxis(int axisIndex, R3Point planeCentre, int planeNumber);

        R3Plane ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes, int planeNumber);

        R3Plane RotateAroundAxis(int indexOfAxis, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre, int planeNumber);

        void FillDirections();
    }
}
