using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Game_Defination;
using Pieces;

namespace Primary_Queen
{
    public class R1Point : RetrievableDimension, ITranslate<R1Point>, IComparable<R1Point>, IDisplay, IReflect<R1Point>, Reflectable<R1Point>
    {
        private Point point;

        public R1Point()
        {

        }

        public R1Point(float xCoordinate)
        {

        }

        public void setXCoordinate(float xCoordinate)
        {

        }

        public float getXCoordinate()
        {
            return 1.0f;
        }

        public void increaseXCoordinate(float amount)
        {

        }

        public void decreaseXCoordinate(float amount)
        {

        }

        public int getDimension()
        {
            throw new NotImplementedException();
        }

        public R1Point translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }

        public R1Point reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public R1Point reflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public void display()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(R1Point other)
        {
            throw new NotImplementedException();
        }
    }
}
