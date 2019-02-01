using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pieces;

namespace ShootingStrategy
{
    public class VectorShootingStrategy
    {
        private Plane onPlane;
        private VectorShootType shootType;
        private List<int> currentVectors;



        public Plane OnPlane
        {
            get
            {
                return onPlane;
            }

            set
            {

            }
        }

        public VectorShootType ShootType
        {
            get
            {
                return shootType;
            }

            set
            {

            }
        }

        public List<int> CurrentVectors
        {
            get
            {
                return currentVectors;
            }

            set
            {

            }
        }

        

        public VectorShootingStrategy()
        {

        }

        public VectorShootingStrategy(Plane onPlane, VectorShootType shootType, List<int> currentVectors)
        {

        }

        public VectorShootingStrategy(Plane onPlane, VectorShootType shootType, Shoot shootingStrategy)
        {

        }
    }
}
