using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingBlocks;
using Game_Defination;
using Pieces;

namespace Tertiary_Queen
{
    public class R3Point:RetrievableDimension,ITranslate<R3Point>,IComparable<R3Point>,IDisplay,IReflect<R3Point>, Reflectable<R3Point>
    {
        private Point point;

        public R3Point()
        {

        }

        public R3Point(float xCoordinate, float yCoordinate, float zCoordinate)
        {

        }

        public float getXCoordinate()
        {
            return 0.0f;
        }

        public void setXCoordinate(float xCoordinate)
        {

        }

        public void increaseXCoordinate(float amount)
        {

        }

        public void decreaseXCoordinate(float amount)
        {

        }

        public float getYCoordinate()
        {
            return 0.0f;
        }

        public void setYCoordinate(float yCoordinate)
        {

        }

        public void increaseYCoordinate(float amount)
        {

        }

        public void decreaseYCoordinate(float amount)
        {

        }

        public float getZCoordinate()
        {
            return 0.0f;
        }

        public void setZCoordinate(float yCoordinate)
        {

        }

        public void increaseZCoordinate(float amount)
        {

        }

        public void decreaseZCoordinate(float amount)
        {

        }

        public Point getPoint()
        {
            return point;
        }

        public int getDimension()
        {
            throw new NotImplementedException();
        }

        public R3Point translate(int coordinateSystemDirection, float amaunt)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(R3Point other)
        {
            throw new NotImplementedException();
        }

        public void display()
        {
            throw new NotImplementedException();
        }

        public R3Point reflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public R3Point reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }
    }
}
