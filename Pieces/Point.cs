using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace Pieces
{
    public class Point : RetrievableDimension, IDisplay
    {
        private List<float> _coordinate;
        private bool canShoot;


        public Point()
        {
            _coordinate = new List<float> { 0, 0f };
            _coordinate.Add(0.0f);
            canShoot = false;
        }

        public Point(List<float> coordinate, bool canShoot)
        {
            if(coordinate.Count>0)
                _coordinate = coordinate;
            this.canShoot = canShoot;

        }

        public int compareTo(Point point)
        {
            if (point._coordinate.Count == _coordinate.Count)
            {
                for (int j = 0; j < point._coordinate.Count; j++)
                    if (_coordinate[j] < point._coordinate[j])
                        return -1;
                    else if(_coordinate[j] > point._coordinate[j])
                        return 1;
                return 0;
            }

            return -99;
        }

        public bool CanShoot { get; set; }
        public List<float> Coordinate{get { return _coordinate; }}

        // Checked
        public void setAxisAt(int coordinateAt, float value)
        {
            if (coordinateAt >= 0 && coordinateAt < _coordinate.Count)
                _coordinate[coordinateAt] = value;

        }
        // Checked
        // Return the first element if the coordinateAt parameter is out of range.
        public float getAxisAt(int coordinateAt)
        {

            if ((coordinateAt >= 0 && coordinateAt < _coordinate.Count))
                return _coordinate[coordinateAt];

             return _coordinate[0];
        }

        public void decreaseAxisAt(int coordinateAt, float amount)
        {
            if (coordinateAt >= 0 && coordinateAt < _coordinate.Count)
                _coordinate[coordinateAt] = _coordinate[coordinateAt]-amount; 
        }

        public void increaseAxisAt(int coordinateAt, float amount)
        {
            if (coordinateAt >= 0 && coordinateAt < _coordinate.Count)
                _coordinate[coordinateAt] = _coordinate[coordinateAt]+amount;
        }

        public int getDimension()
        {
            return _coordinate.Count;
        }

        public void display()
        {
            Console.Write("(");

            for (int i = 0; i <_coordinate.Count-1;i++)
                Console.Write(_coordinate[i]+" , ");
            Console.Write(_coordinate[_coordinate.Count - 1] + ") ");
        }
    }
}
