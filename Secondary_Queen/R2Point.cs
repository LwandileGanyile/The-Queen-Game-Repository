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

        private Point _point;

        public R2Point()
        {
            _point = new Point(new List<float> { 0.0f, 0.0f }, false);
        }

        public R2Point(Point point)
        {
            _point = point;
        }

        public R2Point(float xCoordinate, float yCoordinate)
        {
            _point = new Point(new List<float> { xCoordinate, yCoordinate }, false);
        }

        public R2Point(float xCoordinate, float yCoordinate,bool canShoot)
        {
            _point = new Point(new List<float> { xCoordinate, yCoordinate }, canShoot);
        }

        public Point Point
        {
            get { return _point; }
        }

        public int CompareTo(R2Point other)
        {
            return _point.compareTo(other.Point);
        }

        public void display()
        {
            Console.Write("("+_point.getAxisAt(0)+","+ _point.getAxisAt(1)+") ");
        }

        public int getDimension()
        {
            return _point.getDimension();
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
            _point.increaseAxisAt(0, amount);

        }


        public void increaseYCoordinate(float amount)
        {
            _point.increaseAxisAt(1, amount);
        }

        public void decreaseXCoordinate(float amount)
        {
            _point.decreaseAxisAt(0, amount);
        }


        public void decreaseYCoordinate(float amount)
        {
            _point.decreaseAxisAt(1, amount);
        }

        public void setXCoordinate(float xCoordinate)
        {
            _point.setAxisAt(0,xCoordinate);
        }

        public void setYCoordinate(float yCoordinate)
        {
            _point.setAxisAt(0, yCoordinate);
        }

        public float getXCoordinate()
        {
            return _point.getAxisAt(0);
        }

        public float getYCoordinate()
        {
            return _point.getAxisAt(1);
        }
    }
}
