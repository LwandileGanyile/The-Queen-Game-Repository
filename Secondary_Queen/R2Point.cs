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

        /* Used to access methods and attributes by this class because any n 
        dimensional point isn't allowed to directly access the Point class.*/
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

        public Point Position
        {
            get { return _point; }
        }

        /* Compare any two R2Point objects, the returned values is -1, 0, 1, or -99
           if the returned value is -99 it means the two points are of different dimension.*/
        public int CompareTo(R2Point other)
        {
            return _point.compareTo(other.Position);
        }

        // Display a 2 dimensional point in the form (x,y).
        public void display()
        {
            if(_point != null)
                _point.display();

        }

        // Negative x or y of this point.
        public void negateAtCoornate(int axisAt)
        {
            _point.negateAtCoornate(axisAt);

        }

        // The dimension of this point. It will always be 2.
        public int getDimension()
        {
            return _point.getDimension();
        }

        // Return a new R2Point as a result of reflecting this R2Point about the x-axis or y-axis.
        public R2Point reflectAboutAxis(int axisIndex)
        {
            return new R2Point((axisIndex==2)?-getXCoordinate():getXCoordinate(), (axisIndex == 1) ? -getYCoordinate() : getYCoordinate());
        }

        // Return a new R2Point as a result of reflecting this R2Point about the line y=x or y = -x.
        // 0 -  means no axis, 1 - means on the positive axis and -1 - means on the positive axis.
        // axisIndex[0] is the x-axis value and axisIndex[1] is the y-axis value.
        public R2Point reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            float initialX = getXCoordinate();
            float initialY = getYCoordinate();
            
            

            // Direction 6 or direction 7.
            if ((axisIndeces[0] == 1 && axisIndeces[1] == 1) || (axisIndeces[0] == -1 && axisIndeces[1] == -1))
            {
                if (numberOfTimes % 2 == 0)
                {
                    return new R2Point(initialX, initialY);
                }
                else
                {

                    return new R2Point(initialY, initialX);
                }
            }

            // Direction 4 or direction 5.
            else if ((axisIndeces[0] == -1 && axisIndeces[1] == 1) || (axisIndeces[0] == 1 && axisIndeces[1] == -1))
            {
                if (numberOfTimes % 2 == 0)
                {
                    return new R2Point(initialX, initialY);
                }
                else
                {

                    return new R2Point(-initialY, initialX);
                }
            }

            return new R2Point(initialX, initialY);
        }

        // Move point along any one of the eight directions by a certain amount.
        public R2Point translate(int coordinateSystemDirection, float amount)
        {
            float initialX = _point.getAxisAt(0);
            float finalX = initialX;
            float initialY = _point.getAxisAt(1);
            float finalY = initialY;


            switch (coordinateSystemDirection)
            {
                case 1:
                    finalX -= amount;
                    break;
                case 2:
                    finalY += amount;
                    break;
                case 3:
                    finalY -= amount;
                    break;
                case 4:
                    finalY += amount;
                    finalX -= amount;
                    break;
                case 5:
                    finalX += amount;
                    finalY -= amount;
                    break;
                case 6:
                    finalX += amount;
                    finalY += amount;
                    break;
                case 7:
                    finalX -= amount;
                    finalY -= amount;
                    break;
                default:
                    finalX += amount;
                    break;

            }

            return new R2Point(finalX,finalY);

        }

        // Increase the value of the x-coordinate by amount.
        public void increaseXCoordinate(float amount)
        {
            _point.increaseAxisAt(0, amount);

        }

        // Increase the value of the y-coordinate by amount.
        public void increaseYCoordinate(float amount)
        {
            _point.increaseAxisAt(1, amount);
        }

        // Decrease the value of the x-coordinate by amount.
        public void decreaseXCoordinate(float amount)
        {
            _point.decreaseAxisAt(0, amount);
        }

        // Decrease the value of the y-coordinate by amount..
        public void decreaseYCoordinate(float amount)
        {
            _point.decreaseAxisAt(1, amount);
        }

        // Set x-coordinate to a new value.
        public void setXCoordinate(float xCoordinate)
        {
            _point.setAxisAt(0,xCoordinate);
        }

        // Set y-coordinate to a new value.
        public void setYCoordinate(float yCoordinate)
        {
            _point.setAxisAt(1, yCoordinate);
        }

        // Retrieve x-coordinate.
        public float getXCoordinate()
        {
            return _point.getAxisAt(0);
        }

        // Retrieve y-coordinate.
        public float getYCoordinate()
        {
            return _point.getAxisAt(1);
        }
    }
}
