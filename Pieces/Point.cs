﻿using System;
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

        // Status - Checked , Result - working.
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
        public List<float> Coordinate
        {
            get
            {
                return _coordinate;
            }

            set
            {
                _coordinate = value;
            }
        }

        // Status - Checked , Result - working.
        public void setAxisAt(int coordinateAt, float value)
        {
            if (coordinateAt >= 0 && coordinateAt < _coordinate.Count)
                _coordinate[coordinateAt] = value;
            else if (coordinateAt >= _coordinate.Count)
                _coordinate[_coordinate.Count - 1] = value ;
            else
                _coordinate[0] = value; ;

        }

        // Status - Checked , Result - working.
        // Return the first element if the coordinateAt parameter is out of range.
        public float getAxisAt(int coordinateAt)
        {

            if ((coordinateAt >= 0 && coordinateAt < _coordinate.Count))
                return _coordinate[coordinateAt];
            else if (coordinateAt >= _coordinate.Count)
                return _coordinate[_coordinate.Count - 1];
            else
                return _coordinate[0];
        }


        // Status - Checked , Result - working.
        // The method only works for a valid coordinate index.
        public void decreaseAxisAt(int coordinateAt, float amount)
        {
            if (coordinateAt >= 0 && coordinateAt < _coordinate.Count)
                _coordinate[coordinateAt] = _coordinate[coordinateAt]-amount; 
        }

        // Status - Checked , Result - working.
        // The method only works for a valid coordinate index.
        public void increaseAxisAt(int coordinateAt, float amount)
        {
            if (coordinateAt >= 0 && coordinateAt < _coordinate.Count)
                _coordinate[coordinateAt] = _coordinate[coordinateAt]+amount;
        }

        // Status - Checked , Result - working.
        public int getDimension()
        {
            return _coordinate.Count;
        }

        // Status - Checked , Result - working.
        public void display()
        {
            Console.Write("(");

            for (int i = 0; i <_coordinate.Count;i++)
                if(i< _coordinate.Count - 1)
                    Console.Write(_coordinate[i]+" , ");
                else
                    Console.Write(_coordinate[_coordinate.Count - 1] + ") ");
        }
    }
}
