using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tertiary_Queen
{
    public interface ITransformation<T>
    {
        T ReflectAboutAxis(int axisIndex, R3Point planeCentre, int planeNumber);
        T ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes, int planeNumber);
        T RotateAroundAxis(int indexOfAxis, int numberOfTimes, NumberOFPlanes numberOfPlanes, R3Point planeCentre, int planeNumber);
    }
}
