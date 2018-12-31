using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;
using Pieces;

namespace Secondary_Queen
{
    public class R2Point : RetrievableDimension, ITranslate<R2Point>, IComparable<R2Point>, IDisplay, IReflect<R2Point>, Reflectable<R2Point>
    {

        private Point point;

        public R2Point()
        {

        }

        public R2Point(float xCoordinate, float yCoordinate)
        {

        }

        public int CompareTo(R2Point other)
        {
            throw new NotImplementedException();
        }

        public void display()
        {
            throw new NotImplementedException();
        }

        public int getDimension()
        {
            throw new NotImplementedException();
        }

        public R2Point reflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public R2Point reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public R2Point translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }

        public void increaseXCoordinate(float amount)
        {

        }


        public void increaseYCoordinate(float amount)
        {

        }

        public void decreaseXCoordinate(float amount)
        {

        }


        public void decreaseYCoordinate(float amount)
        {

        }

        public void setXCoordinate(float xCoordinate)
        {

        }

        public void setYCoordinate(float yCoordinate)
        {

        }

        public float getXCoordinate()
        {
            return 0.0f;
        }

        public float getYCoordinate()
        {
            return 0.0f;
        }
    }
}
