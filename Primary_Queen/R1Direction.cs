using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary_Queen
{
    public class R1Direction
    {





        // Determines whether or not a direction is within the boundaries.
        public bool IsDirectionValid(int direction)
        {
            return direction == 1 || direction == 2;
        }
    }
}
