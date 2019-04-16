using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedResources;

namespace BuildingBlocks
{
    /* The class contains fields and methods that a common in 
     CircularDirection and NonCircularDirection.*/
    public class SharedDirection
    {
        internal float _directionLength;
        internal float _divisor;

        //internal float _duration;

        public SharedDirection()
        {
            _divisor = 1;
            _directionLength = 10;
        }

        public SharedDirection(float _divisor)
        {
            this._divisor = _divisor;

            if (10 % _divisor == 0)
                _directionLength = 10 * _divisor;
            else
            {
                _divisor = 1.0f;
                _directionLength = 10 ;
            }
        }

      

        public SharedDirection(float _directionLength,float _divisor)
        {
            this._divisor = _divisor;
            this._directionLength = _directionLength;
        }

        public override string ToString()
        {
            return "Direciton length : " + _directionLength + "\nDirection Divisor : " + _divisor;
        }

        public float Divisor
        {
            get
            {
                return _divisor;
            }

            set
            {
                if (_divisor != 0)
                    _divisor = value;
            }
        }


        public float DirectionLength
        {
            get
            {
                return _directionLength;
            }

            set
            {

                if (_directionLength > 0)
                    _directionLength = value;

            }
        }


    }
}
