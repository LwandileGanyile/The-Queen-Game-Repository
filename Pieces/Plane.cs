using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_Defination;

namespace Pieces
{
    public abstract class Plane : IReflectable<Plane>, IRotateable<Plane>, IReflect<Plane>, IRotate<Plane>
    {
        protected int planeDimension;
        protected int planeNumber;
        protected Point planeCentre;
        protected List<int> directions;

        protected Plane()
        {

        }

        protected Plane(Point planeCentre, int planeDimension, int planeNumber)
        {

        }

        public bool AreDirectionsOnPlane(List<int> directions)
        {
            return false;
        }

        public bool AreNFarAway(int direction1, int direction2, int howFar)
        {
            return false;
        }

        public static List<int> RetrieveAllNeighborDirections(int direction)
        {
            return null;
        }

        public static List<int> RetrieveAllPerpendicularDirections(int direction)
        {
            return null;
        }

        public int[] RetrieveNeighborDirections(int direction)
        {
            int[] array = new int[2];
            return array;
        }

        public int[] RetrievePerpendicularDirections(int direction)
        {
            int[] array = new int[2];
            return array;
        }

        public bool RreDirectionsNeighbors(int direction1, int direction2)
        {
            return false;
        }

        public bool RreDirectionsPerpendicular(int direction1, int direction2)
        {
            return false;
        }

        protected void RillDirections()
        {

        }

        public Plane ReflectAroundEqualAxis(List<int> axisIndeces, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public Plane RotateAroundEqualAxis(List<int> indecesOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public Plane ReflectAboutAxis(int axisIndex)
        {
            throw new NotImplementedException();
        }

        public Plane RotateAroundAxis(int indexOfAxis, int numberOfTimes)
        {
            throw new NotImplementedException();
        }

        public List<int> planeDirections
        {
            get
            {
                return null;
            }
        }

        public Point PlaneCentre { get; set; }

        public int PlaneNumber { get; }

        public int PlaneDimension { get { return 1; } }
    }
}
