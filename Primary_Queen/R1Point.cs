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
        /* Used to access methods and attributes by this class because any n 
        dimensional point isn't allowed to directly access the Point class.*/
        private Point point;

        public R1Point()
        {
            point = new Point();
        }

        public R1Point(float xCoordinate)
        {
            point = new Point(new List<float> { xCoordinate},false);
        }

        public R1Point(Point point)
        {
            this.point = point;
        }

        // Status - Checked , Result - working.
        public void setXCoordinate(float xCoordinate)
        {
            point.setAxisAt(0, xCoordinate);
        }

        public Point Position
        {
            get { return point; }
        }

        // Retrieve x- value.
        public float getXCoordinate()
        {
            return point.getAxisAt(0);
        }

        // Increasing the current x value by amount.
        public void increaseXCoordinate(float amount)
        {
            point.increaseAxisAt(0,amount);
        }

        // Decreasing the current x value by amount.
        public void decreaseXCoordinate(float amount)
        {
            point.decreaseAxisAt(0, amount);
        }

        // The dimension will always be 1.
        public int getDimension()
        {
            return point.Dimension;
        }

        // Move a point a long a number line.
        public R1Point translate(int coordinateSystemDirection, float amount)
        {

            if (coordinateSystemDirection == 1)
                return new R1Point(point.getAxisAt(0) - amount);
            else if (coordinateSystemDirection >= 2)
                return new R1Point(point.getAxisAt(0) + amount);

            return new R1Point(point.getAxisAt(0));
           
        }

        // The method is unsupported to this class however it is implemented.
        // The method returns a copy of this instance.
        public R1Point reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {

            return new R1Point(point.getAxisAt(0));
        }

        // Negative x of this point.
        public void negateAtCoornate(int axisAt)
        {
            if(axisAt==1)
                point.negateAtCoornate(axisAt);

        }

        // Return a new R1Point as a result of reflecting this R1Point about the origin.
        // The axisIndex value equals to 0 means reflecting about the origin.
        public R1Point reflectAboutAxis(int axisIndex)
        {
            if (axisIndex == 0)
                return new R1Point(-point.getAxisAt(0));
            return new R1Point(point.getAxisAt(0));
        }

        // Display a 1 dimensional point in the form (x).
        public void display()
        {
            if (point != null)
                point.display();
        }

        /* Compare any two R1Point objects, the returned values is -1, 0, 1, or -99
           if the returned value is -99 it means the two points are of different dimension.*/
        public int CompareTo(R1Point other)
        {
          
            return point.compareTo(other.Position);
        }
    }
}
