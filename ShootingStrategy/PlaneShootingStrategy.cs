using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace ShootingStrategy
{
    public class PlaneShootingStrategy
    {
        private List<Plane> planes;
        private PlaneShootType shootType;

        public List<Plane> Planes
        {
            get
            {
                return planes;
            }

            set
            {
                
            }
        }

        public PlaneShootType ShootType
        {
            get
            {
                return shootType;
            }

            set
            {

            }
        }

        public PlaneShootingStrategy()
        {

        }

        public PlaneShootingStrategy(List<Plane> planes, PlaneShootType shootType)
        {

        }

        public PlaneShootingStrategy(Shoot shoot, PlaneShootType shootType)
        {

        }
    }
}
