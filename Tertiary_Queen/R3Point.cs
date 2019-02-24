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
    public class R3Point:RetrievableDimension,ITranslate<R3Point>,IComparable<R3Point>,IDisplay,IReflect<R3Point>, IReflectable<R3Point>
    {
        private Point _point;

        public R3Point()
        {

        }

        public R3Point(float xCoordinate, float yCoordinate, float zCoordinate)
        {

        }

        public Point Position
        {
            get;
            set;
        }

        public float this[int index]
        {
            get { return _point.GetAxisAt(index); }

            set { _point.SetAxisAt(index, value); }
        }

        public float this[char axisValue]
        {
            get
            {
                float returnValue;
                if (axisValue == 'x' || axisValue == 'X')
                    returnValue = _point.GetAxisAt(0);
                else if (axisValue == 'y' || axisValue == 'Y')
                    returnValue = _point.GetAxisAt(1);
                else if (axisValue == 'z' || axisValue == 'Z')
                    returnValue = _point.GetAxisAt(2);
                else
                    returnValue = _point.GetAxisAt(3);
                return returnValue;
            }

            set
            {
                float returnValue;
                if (value == 'x' || value == 'X')
                    _point.SetAxisAt(0, value);
                else if (value == 'y' || value == 'Y')
                    _point.SetAxisAt(1, value);
                else if (value == 'z' || value == 'Z')
                    _point.SetAxisAt(2, value);
                else
                    returnValue = _point.GetAxisAt(3);
                _point.SetAxisAt(3, value);
            }
        }

        public float GetXCoordinate()
        {
            return this['x'];
        }

        public void SetXCoordinate(float xCoordinate)
        {
            this['X'] = xCoordinate;
        }

        public void IncreaseXCoordinate(float amount)
        {

        }

        public void DecreaseXCoordinate(float amount)
        {

        }

        public float GetYCoordinate()
        {
            return _point.GetAxisAt(1);
        }

        public void SetYCoordinate(float yCoordinate)
        {
            _point.SetAxisAt(1,yCoordinate);
        }

        public void IncreaseYCoordinate(float amount)
        {

        }

        public void DecreaseYCoordinate(float amount)
        {

        }

        public float GetZCoordinate()
        {
            return this[2];
        }

        public void SetZCoordinate(float zCoordinate)
        {
            this[2] = zCoordinate;
        }

        public void IncreaseZCoordinate(float amount)
        {

        }

        public void DecreaseZCoordinate(float amount)
        {

        }

        public Point GetPoint()
        {
            return _point;
        }

        public int GetDimension()
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

        public void Display()
        {
            throw new NotImplementedException();
        }

        public R3Point ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public R3Point ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public R3Point ReflectAboutEqualAxis(int[] axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }
    }
}
