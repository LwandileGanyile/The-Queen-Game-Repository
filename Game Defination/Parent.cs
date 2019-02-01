using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace BuildingBlocks
{
    public class Parent
    {

        protected Point _startingPoint;

        protected int direction;
        protected List<bool> canShootList;
        protected int duration;
        // Letters are made up of directions having each piece equals to divisor.
        protected int dimension; // Dimenison.

        protected Parent()
        {
            _startingPoint = new Point();
            direction = 1;
            duration = 1000;
            dimension = 1;
            canShootList = new List<bool> { false };

        }


        protected Parent(Point _startingPoint, int direction,
        float divisor, int duration, int directionDimension, int numberOfRotations)
        {
            this._startingPoint = _startingPoint;
            this.direction = direction;
            this.duration = duration;
            canShootList = new List<bool> { true };
            dimension = _startingPoint.Dimension;
        }

        protected Parent(Point _startingPoint, int direction,
        float divisor, List<bool> canShootList, int duration, int directionDimension, int numberOfRotations)
        {
            this._startingPoint = _startingPoint;
            this.direction = direction;
            this.duration = duration;
            dimension = _startingPoint.Dimension;
            this.canShootList = canShootList;
        }

        public int Direction { get { return direction; } }
        public int Dimension { get { return dimension; } }
        public List<bool> CanShoot { get { return canShootList; } }
        public int Duration { get { return duration; } }
        public Point StartingPoint { get { return _startingPoint; } set { _startingPoint = value; } }



    }
}
