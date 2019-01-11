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

        // Status - Checked , Result - working.
        public float getXCoordinate()
        {
            return point.getAxisAt(0);
        }

        // Status - Checked , Result - working.
        public void increaseXCoordinate(float amount)
        {
            point.increaseAxisAt(0,amount);
        }

        // Status - Checked , Result - working.
        public void decreaseXCoordinate(float amount)
        {
            point.decreaseAxisAt(0, amount);
        }

        // Status - Checked , Result - working.
        public int getDimension()
        {
            return point.Dimension;
        }

        // Status - Checked , Result - working.
        public R1Point translate(int coordinateSystemDirection, float amount)
        {

            if (coordinateSystemDirection == 1)
                return new R1Point(point.getAxisAt(0) - amount);

            return new R1Point(point.getAxisAt(0) + amount);
           
        }

        // Status - Checked , Result - working.
        public R1Point reflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {

            return this;
        }

        // Status - Checked , Result - working.
        public R1Point reflectAboutAxis(int axisIndex)
        {
            if (axisIndex == 1)
                return new R1Point(-point.getAxisAt(0));
            return this;
        }

        // Status - Checked , Result - working.
        public void display()
        {
            Console.Write("(" + point.getAxisAt(0)+ ") ");
        }

        // Status - Checked , Result - working.
        public int CompareTo(R1Point other)
        {
            int returnValue = -99;

            if (point.getAxisAt(0) < other.Position.getAxisAt(0))
                returnValue = -1;
            else if (point.getAxisAt(0) > other.Position.getAxisAt(0))
                returnValue = 1;
            else if(point.getAxisAt(0) == other.Position.getAxisAt(0))
                returnValue = 0;

            return returnValue;
        }
    }
}
