using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingStrategy
{
    public abstract class NonCircularPlaneShootingStrategy
    {
        protected PlaneShootingStrategy shootingStrategy;

        protected NonCircularPlaneShootingStrategy()
        {

        }

        protected NonCircularPlaneShootingStrategy(PlaneShootingStrategy shootingStrategy)
        {

        }
    }
}
