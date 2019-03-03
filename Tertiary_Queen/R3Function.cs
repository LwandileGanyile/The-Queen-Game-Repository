using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;


namespace Tertiary_Queen
{
    public class R3Function : IRotate<R3Function>, IReflect<R3Function>, IReflectable<R3Function>, ITranslate<R3Function>
    {
        private float xValue;
        private float yValue;
        private float zValue;

        public R3Function()
        {

        }

        public R3Function(string r3equation)
        {

        }

        public R3Function ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public R3Function ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public R3Function RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public R3Function translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }
    }
}
