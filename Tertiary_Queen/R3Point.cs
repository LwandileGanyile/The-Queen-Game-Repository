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

        public float GetXCoordinate()
        {
            return 0.0f;
        }

        public void SetXCoordinate(float xCoordinate)
        {

        }

        public void IncreaseXCoordinate(float amount)
        {

        }

        public void DecreaseXCoordinate(float amount)
        {

        }

        public float GetYCoordinate()
        {
            return 0.0f;
        }

        public void SetYCoordinate(float yCoordinate)
        {

        }

        public void IncreaseYCoordinate(float amount)
        {

        }

        public void DecreaseYCoordinate(float amount)
        {

        }

        public float GetZCoordinate()
        {
            return 0.0f;
        }

        public void SetZCoordinate(float yCoordinate)
        {

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
    }
}
