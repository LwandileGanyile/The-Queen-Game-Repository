using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace Parents
{
    public abstract class Parent: IFill
    {

        protected Point _startingPoint;

        protected int direction;
        protected List<bool> canShootList;
        protected int duration;
        // Letters are made up of directions having each piece equals to divisor.
        protected int dimension; // Dimenison.

        protected Parent()
        {
            _startingPoint = null;
            direction = 2;
            duration = 1000;
            dimension = -1;
            canShootList = null;

        }


        protected Parent(Point _startingPoint, int direction,
        float divisor, int duration, int directionDimension, int numberOfRotations)
        {
            this._startingPoint = _startingPoint;
            this.direction = direction;
            this.duration = duration;
            canShootList = null;
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

        public int Direction
        {
            get
            {
                return direction;
            }

            set
            {
                Clear();
                direction = value;
                Fill();
            }

        }
        public int Dimension { get { return dimension; } }
        public int Duration
        {
            get
            {
                return duration; }
            set
            {

            }
        }
        public List<bool> CanShoot
        {
            get
            {
                return canShootList;
            }

            set
            {
                if (value.Count == canShootList.Count)
                    canShootList = value;
            }
        }

        public Point StartingPoint {

            get
            {
                return _startingPoint;
            }

            set
            {
                Clear();
                _startingPoint = value;
                Fill();
            }
        }

        public abstract void Fill();

        public abstract void Clear();
    }
}
